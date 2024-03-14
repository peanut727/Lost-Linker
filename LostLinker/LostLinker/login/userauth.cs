using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace LostLinker.login
{
    internal class userauth
    {
        dbconnector dbconn = new dbconnector();
        public bool authUser(string username, string password)
        {
          
          MySqlConnection conn = dbconn.GetConnection();
        
            try
            {
                conn.Open();
                string query = "SELECT userpass FROM Users WHERE Username = @Username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string storedPass = reader.GetString(0);
                    return BCrypt.Net.BCrypt.Verify(password, storedPass);
                }
                conn.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.Close();
            }
            return false;

        }

        public bool authAdmin(string username, string password)
        {
            MySqlConnection conn = dbconn.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT password FROM Admin WHERE username = @Username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string storedPass = reader.GetString(0);
                    return BCrypt.Net.BCrypt.Verify(password, storedPass);

                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("");
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
