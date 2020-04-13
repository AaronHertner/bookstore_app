using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace COMP3005
{
    internal class SQL
    {
        private static string connectionString = "Server=localhost;Port=5432;User Id=postgres;" +
            "Password=hertner5;Database=3005project";

        private static NpgsqlConnection conn = new NpgsqlConnection(connectionString);
        private static string sql;
        private static NpgsqlCommand cmd;

        public static DataTable SQLcommand(string query)
        {
            try
            {
                //init command
                sql = query;
                cmd = new NpgsqlCommand(sql, conn);

                //retrieve data
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();

                return dt;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("ERROR: COULD NOT CONNECT TO DATABASE -> " + ex.ToString());
                return null;
            }
        }

        public static void add_to_db(string query) 
        {
            try
            {
                //init command
                sql = query;
                cmd = new NpgsqlCommand(sql, conn);

                //retrieve data
                conn.Open();
                cmd.ExecuteScalar();
                conn.Close();

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("ERROR: COULD NOT CONNECT TO DATABASE -> " + ex.ToString());
            }
        }

        public static int get_userID(string email) 
        {
            try
            {
                //init command
                sql = "select * from users where email = " + "'" + email + "';";
                cmd = new NpgsqlCommand(sql, conn);

                //retrieve data
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();

                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows) { return (int)row[0]; }
                }
                return -1;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("ERROR: COULD NOT CONNECT TO DATABASE -> " + ex.ToString());
                return -1;
            }

        }
    }
}