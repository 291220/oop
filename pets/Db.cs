using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pets
{
    internal class Db
    {
         private static string _db;

            public static string _server;
            private static string _port;
            private static string _username;
            private static string _password;

            private static MySqlConnection conn;

            public static void SetParams(string db, string server, string port, string username, string password)
            {
                _db = db;
                _server = server;
                _username = username;
                _password = password;
                _port = port;

                //conn = new MySqlConnection();
                string ConnectionString;
                ConnectionString =
                    $"Server={_server};Database={_db};User ID={_username};Password={_password}";
                conn = new MySqlConnection(ConnectionString);

            }

            public static bool testConnection()
            {
                try
                {
                    //some validation
                    if (conn.ConnectionString == "")
                        return false;
                    conn.Open();
                    conn.Close();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }

            public static bool Execute(string sql)
            {
                conn.Open();
                try
                {
                    //some validation
                    //looks pretty irrelevant ==> festus ==> check
                    if (conn.ConnectionString == "")
                        return false;

                    //you code may come here if you weany 
                    var da = new MySqlCommand(sql, conn);

                    da.ExecuteNonQuery();
                    da.Dispose();
                    conn.Close();

                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    conn.Close();
                    return false;
                }
            }


            public static DataTable GetData(string sql)
            {
                conn.Open();
                try
                {
                    var cmd = new MySqlCommand(sql, conn);
                    var da = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    conn.Close();
                    return dt;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    conn.Close();
                    return null;
                }
            }


        
    }
}
