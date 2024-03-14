using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostLinker.login
{
    public partial class querytests : Form
    {
        dbconnector dbcon = new dbconnector();
        private MySqlConnection conn;
        public querytests()
        {
            InitializeComponent();
            conn = dbcon.GetConnection();
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

        }

        private string tableLoc;
        private void button1_Click(object sender, EventArgs e)
        {
            tableLoc = "Items";
            try
            {
                conn.Open();
                string query = "SELECT item_id, item_name, description, found_date, found_time, status FROM Items";
                MySqlDataAdapter SDA = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(SDA);
                var ds = new DataSet();
                SDA.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                string query = "DELETE FROM Items WHERE item_id = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int itemID = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                cmd.Parameters.AddWithValue("@ID", itemID);
                int rowsDel = cmd.ExecuteNonQuery();
                if (rowsDel > 0)
                {
                    MessageBox.Show("Deleted!");
                }
                else
                {
                    MessageBox.Show("Failed!");
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
        }

       

        private void claimsBtn_Click(object sender, EventArgs e)
        {
            tableLoc = "Claims";
            try
            {
                conn.Open();
                string query = "SELECT claim_id, item_id, item_name, claimer_name, claim_date, imageUrl, status FROM Claims";
                MySqlDataAdapter SDA = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(SDA);
                var ds = new DataSet();
                SDA.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            loginn login = new loginn();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            itemButton.BackColor = Color.FromArgb(30, 33, 36);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLoc = "Users";
            try
            {
                conn.Open();
                string query = "SELECT user_id, username, email, userpass, phoneNumber FROM Users";
                MySqlDataAdapter SDA = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(SDA);
                var ds = new DataSet();
                SDA.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                Debug.WriteLine("Connection opened");

                // Check if any rows are selected
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow modifiedRow in dataGridView1.SelectedRows)
                    {
                        Debug.WriteLine("Loop");
                        DataRowView drv = modifiedRow.DataBoundItem as DataRowView;
                        DataRow modifiedDataRow = drv.Row;
                        if (tableLoc == "Items")
                        {
                            using (MySqlCommand cmd = new MySqlCommand("UPDATE Items SET item_name = @itemName, description = @description, found_date = @foundDate, found_time = @foundTime, status = @status WHERE item_id = @itemId", conn))
                            {
                                cmd.Parameters.AddWithValue("@itemName", modifiedDataRow["item_name"]);
                                cmd.Parameters.AddWithValue("@description", modifiedDataRow["description"]);
                                cmd.Parameters.AddWithValue("@foundDate", modifiedDataRow["found_date"]);
                                cmd.Parameters.AddWithValue("@foundTime", modifiedDataRow["found_time"]);
                                cmd.Parameters.AddWithValue("@status", modifiedDataRow["status"]);
                                cmd.Parameters.AddWithValue("@itemId", modifiedDataRow["item_id"]);

                                cmd.ExecuteNonQuery();
                                Debug.WriteLine("Executed");
                                MessageBox.Show("Success!");
                            }
                        }
                        else if (tableLoc == "Users")
                        {
                            using (MySqlCommand cmd = new MySqlCommand("UPDATE Users SET username = @userName, email = @email, userpass = @Pass, phoneNumber = @PN WHERE user_id = @userId", conn))
                            {

                                cmd.Parameters.AddWithValue("@userName", modifiedDataRow["username"]);
                                cmd.Parameters.AddWithValue("@email", modifiedDataRow["email"]);
                                cmd.Parameters.AddWithValue("@Pass", modifiedDataRow["userpass"]);
                                cmd.Parameters.AddWithValue("@PN", modifiedDataRow["phoneNumber"]);
                                cmd.Parameters.AddWithValue("@userId", modifiedDataRow["user_id"]);

                                
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Success");
                            }
                        } else if (tableLoc == "Claims")
                        {
                            using (MySqlCommand cmd = new MySqlCommand("UPDATE Claims SET item_name = @itemName, claimer_name = @ClaimName, imageUrl = @URL, status = @status WHERE claim_id = @claimId AND item_id = @itemId", conn))
                            {

                                cmd.Parameters.AddWithValue("@itemName", modifiedDataRow["item_name"]);
                                cmd.Parameters.AddWithValue("@ClaimName", modifiedDataRow["claimer_name"]);
                                cmd.Parameters.AddWithValue("@status", modifiedDataRow["status"]);
                                cmd.Parameters.AddWithValue("@URL", modifiedDataRow["imageUrl"]);
                                cmd.Parameters.AddWithValue("@itemId", modifiedDataRow["item_id"]);
                                cmd.Parameters.AddWithValue("@claimId", modifiedDataRow["claim_id"]);

                               
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Success");
                            }
                        }
                       
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to edit.");
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
        }
    }
}
