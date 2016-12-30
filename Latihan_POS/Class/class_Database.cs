using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_POS.Class
{
    class class_Database
    {
        public static MySqlConnection koneksi = new MySqlConnection("Server=localhost;Port=3306;Database=database_pos;Uid=root;password=;");

        public static void open_connection()
        {
            if (koneksi.State != ConnectionState.Open)
                koneksi.Open();
        }

        public static void close_connection()
        {
            if (koneksi.State != ConnectionState.Closed)
                koneksi.Close();
        }
    }
}
