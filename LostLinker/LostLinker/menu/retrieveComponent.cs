using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostLinker.menu
{
    internal class retrieveComponent
    {
        private DataTable retrieveImage()
        {
            dbconnector dbcon = new dbconnector();
            MySqlConnection conn = dbcon.GetConnection();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                string query = "SELECT imageData FROM Items";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                adapt.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        private DataTable retrieveItemData()
        {
            dbconnector dbcon = new dbconnector();
            MySqlConnection conn = dbcon.GetConnection();
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

    }
}
