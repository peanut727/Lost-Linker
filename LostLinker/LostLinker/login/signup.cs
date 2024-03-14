using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace LostLinker.login
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        dbconnector dbcon = new dbconnector();
        private string filepath;
        private byte[] imageData;

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = dbcon.GetConnection();

            if (usertb.Text == "" || passtb.Text == "" || emailtb.Text == "" || phonetb.Text == "" || userpicBox == null)
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    conn.Open();

                    if (passtb.Text.Length < 8)
                    {
                        MessageBox.Show("Password must be at least 8 characters long!");
                        return;
                    }

                    string hashedPass = BCrypt.Net.BCrypt.HashPassword(passtb.Text);
                    string insertQuery = "INSERT INTO Users(username, userpass, email, phoneNumber, imageData) VALUES (@Username, @Password, @Email, @Phone, @imgData)";
                    
                    // to insert admin data into the db
                    // string adminQuery = "INSERT INTO Admin(username, password, email) VALUES (@Username, @Password, @Email)";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@Username", usertb.Text);
                    cmd.Parameters.AddWithValue("@Password", hashedPass);
                    cmd.Parameters.AddWithValue("@Email", emailtb.Text);
                    cmd.Parameters.AddWithValue("@Phone", phonetb.Text);
                    cmd.Parameters.AddWithValue("@imgData", imageData);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User created successfully!");
                        this.Hide();
                        loginn login = new loginn();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create the user!");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                // Show password
                passtb.PasswordChar = '\0';
            }
            else
            {
                // Hide password
                passtb.PasswordChar = '*';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
                    userpicBox.Image = Image.FromFile(filepath);
                    imageData = ic.ConvertImageToBytes(userpicBox.Image);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
    }
}
