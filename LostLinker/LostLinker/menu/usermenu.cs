using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LostLinker.menu
{
    public partial class usermenu : Form
    {
        dbconnector dbcon = new dbconnector();
        private MySqlConnection conn;
        public usermenu()
        {
            InitializeComponent();
            itemReports1.Hide();
            conn = dbcon.GetConnection();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {

            lostitemBtn.BackColor = Color.FromArgb(30, 33, 36);
            reportitemBtn.BackColor = Color.FromArgb(114, 137, 218);
            this.Size = new Size(786, 645);
            itemReports1.Show();
            itemReports1.BringToFront();

        }

        private void lostitemBtn_Click(object sender, EventArgs e)
        {

            lostitemBtn.BackColor = Color.FromArgb(114, 137, 218);
            reportitemBtn.BackColor = Color.FromArgb(30, 33, 36);
            this.Size = new Size(1291, 645);
            itemReports1.Hide();

        }

        private void usermenu_Load(object sender, EventArgs e)
        {
            //lv properties
            listView1.View = View.LargeIcon;

            //construct the colums
            listView1.Columns.Add("Lost Items", 250);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            
            bool populated = populate();

            if (populated)
            {
                populateUser();
            }

            userbtn.Text = loginn.user;
        }
        private void populateUser()
        {
           
            DataTable dt = retrieveUserImage();
            imageconvertion ic = new imageconvertion();

            if (dt.Rows.Count > 0)
            {
                byte[] data = (byte[])dt.Rows[0]["imageData"];
                Image image = ic.ConvertByteArrayToImage(data);

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = image;
            }
        }
        // this populates the list view
        private bool populate()
        {
            imageconvertion ic = new imageconvertion();
            WebClient w = new WebClient();
            DataTable itemTable = retrieveItemData();
            //image list
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(150, 150);

            try
            {
                for (int i = 0; i < itemTable.Rows.Count; i++)
                {
                    int itemId = Convert.ToInt32(itemTable.Rows[i]["item_id"]);
                    string status = itemTable.Rows[i]["status"].ToString();

                    DataRow[] idr = itemTable.Select($"item_id = {itemId}");

                    if (idr.Length > 0)
                    {
                        byte[] imageByte = w.DownloadData(idr[0]["imageLink"].ToString());
                        Image imageData = ic.ConvertByteArrayToImage(imageByte);
                        imgs.Images.Add(imageData);
                        listView1.Items.Add(itemTable.Rows[i]["item_name"].ToString(), imgs.Images.Count - 1);
                    }
                }
                listView1.LargeImageList = imgs;
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "dagis");

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable itemTable = retrieveItemData();

            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].ImageIndex;

                DataRow selectedRow = itemTable.Rows[index];

                try
                {
                    conn.Open();
                    string query = "SELECT description, found_date, found_time, reporter_name FROM Items WHERE item_id = @ItemId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ItemId", selectedRow["item_id"]);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        dateShow.Value = Convert.ToDateTime(reader["found_date"]);
                        textBox2.Text = reader["found_time"].ToString();
                        descTB.Text = reader["description"].ToString();
                        reportLbl.Text = reader["reporter_name"].ToString();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    conn.Close();
                }

                itemPic.SizeMode = PictureBoxSizeMode.Zoom;
                itemPic.Image = listView1.LargeImageList.Images[index];
                String selected = listView1.SelectedItems[0].SubItems[0].Text;
                itemLabel.Text = selected;
            }
        }
        private DataTable retrieveUserImage()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                string query = "SELECT imageData FROM Users WHERE username = @user";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", loginn.user);
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                adapt.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        private DataTable retrieveItemData()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                string query = "SELECT * FROM Items";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                

                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                adapt.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listView1.Clear();
            populate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loginn log = new loginn();
            this.Hide();
            log.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable itemData = retrieveItemData();

            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].ImageIndex;

                DataRow selectedRow = itemData.Rows[index];

                try
                {
                    conn.Open();

                    // inserts data to Claims Table when the item is claimed
                    string insertQuery = "INSERT INTO Claims (item_id, item_name, claimer_name, claim_date, imageUrl, status) VALUES (@ItemID, @ItemName, @ClaimName, @ClaimDate, @ImageUrl, @Status)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@ItemID", selectedRow["item_id"]);
                    cmd.Parameters.AddWithValue("@ItemName", itemLabel.Text);
                    cmd.Parameters.AddWithValue("@ClaimName", loginn.user); ;
                    cmd.Parameters.AddWithValue("@ClaimDate", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@ImageUrl", selectedRow["imageLink"]);
                    cmd.Parameters.AddWithValue("@Status", "Pending");

                    int rowsAffected = cmd.ExecuteNonQuery();

                    // deletes the item on Items table since its getting moved to Claims table
                    string updateStatusQuery = @"DELETE FROM Items WHERE item_id = @ItemID";
                    MySqlCommand updateCmd = new MySqlCommand(updateStatusQuery, conn);
                    updateCmd.Parameters.AddWithValue("@ItemID", selectedRow["item_id"]);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Item is pending to be claimed!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    listView1.Clear();
                    populate();
                }
            }   
        }
    }
}
