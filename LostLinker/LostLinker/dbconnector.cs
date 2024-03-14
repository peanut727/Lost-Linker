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

namespace LostLinker
{
    internal class dbconnector
    {
        private MySqlConnection Conn;
        private const string connName = "dbinfo";
        private string connstring = ConfigurationManager.ConnectionStrings[connName].ConnectionString;

      
        // for connecting to db in other classes
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connstring);
        }

        // for executing queries
        public void queries()
        {
            try
            {
                Conn = new MySqlConnection(connstring);
                Conn.Open();

                string query = @"
   CREATE TABLE Claims (
    claim_id INT PRIMARY KEY AUTO_INCREMENT,
    item_id INT,
    item_name VARCHAR(255),
    claimer_name VARCHAR(255),
    claim_date DATE,
    imageUrl VARCHAR(255),
    status ENUM('Pending', 'Approved', 'Rejected')
);
";
                string del = "DROP TABLE IF EXISTS Claims";
                MySqlCommand cmd = new MySqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }



        // for login purposes
        public bool ConnectDB()
        {

            try
            {

                Conn = new MySqlConnection(connstring);
                Conn.Open();
                //MessageBox.Show("Connected to database!");
                return true;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
                Console.WriteLine(ex.Message);
                //Thread.Sleep(3000);
                //Application.Exit();
                return false;

            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
