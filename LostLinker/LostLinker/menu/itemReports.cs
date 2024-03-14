using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Imgur.API.Authentication;
using Imgur.API.Endpoints;
using Imgur.API;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LostLinker.menu
{
    public partial class itemReports : UserControl
    {
        public itemReports()
        {
            InitializeComponent();
            timepicker.Format = DateTimePickerFormat.Custom;
            timepicker.CustomFormat = "hh:mm tt";
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "MMMM dd, yyyy";
        }

        private string filepath;

        private void addPicture_Click_1(object sender, EventArgs e)
        {
            imageconvertion ic = new imageconvertion();
            OpenFileDialog addfile = new OpenFileDialog();
            addfile.Title = ("Browse Image Files");
            addfile.DefaultExt = "jpg";
            addfile.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            addfile.FilterIndex = 1;

            if (addfile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filepath = addfile.FileName;
                    itemPic.Image = Image.FromFile(filepath);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private string imagelink;
        public async void imgurTest()
        {
            try
            {
                var clientId = "59d8e73afa61b5b";
                var apiClient = new ApiClient(clientId);
                var httpClient = new HttpClient();

                var filePath = filepath;
                using var fileStream = File.OpenRead(filePath);

                var imageEndpoint = new ImageEndpoint(apiClient, httpClient);
                var imageUpload = await imageEndpoint.UploadImageAsync(fileStream);

                // retrieves the uploaded image URL
                var imageUrl = imageUpload.Link;
                imagelink = imageUrl;
                // testing purposes
                label2.Text = imageUrl;
                
            }
            catch (ImgurException ex)
            {
                // imgur api handling
                MessageBox.Show("Imgur API Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // local exception handling
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private async void reportBtn_Click_1(object sender, EventArgs e)
        {
            dbconnector dbcon = new dbconnector();
            MySqlConnection conn = dbcon.GetConnection();

            if (itemtb.Text == "" || descriptiontb.Text == "" || itemPic.Image == null)
            {
                MessageBox.Show("Please fill in the missing fields");
            }
            else
            {
                try
                {
                    imgurTest();
                    await Task.Delay(3500);
                    conn.Open();
                    string insertQuery = "INSERT INTO Items(item_name, found_date, found_time, description, imageLink, status, reporter_name) VALUES (@Item, @Date, @Time, @Description, @ImgLink, @Status, @Reporter)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@Item", itemtb.Text);
                    cmd.Parameters.AddWithValue("@Date", datePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@Time", timepicker.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@Description", descriptiontb.Text);
                    cmd.Parameters.AddWithValue("@ImgLink", label2.Text);
                    cmd.Parameters.AddWithValue("@Status", "Lost");
                    cmd.Parameters.AddWithValue("@Reporter", loginn.user);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Your report has been submitted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Your report has failed to submit. Please try again!");
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
}
