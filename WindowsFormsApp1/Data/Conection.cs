using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Google.Protobuf;
using System.Windows.Forms;

namespace WindowsFormsApp1.Data
{
    internal class Conection
    {
        public static MySqlConnection connection;

        public static String server = "127.0.0.1";
        public static String dataBase = "login";
        public static String user = "root";
        public static String contrasena = "1234";
        public static void OpenConection()
        {
            string connectionString = $"server={server};database={dataBase};user={user};password={contrasena};";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                MessageBox.Show("conexion establecida");
            } else
            {
                MessageBox.Show("Eo: conexion no establecida");
            }
            connection.Close();
        }

        public static void ClousConection()
        {

        }
    }
}
