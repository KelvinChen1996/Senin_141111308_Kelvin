using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Latihan_POS.Class
{
    class class_Penjualan
    {
        private static string tabel = "penjualan";

        public int id { private set; get; }
        public string kode { private set; get; }
        public class_Customer customer { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        public class_Penjualan(int id, string kode, class_Customer customer, DateTime created_at, DateTime updated_at)
        {
            this.id = id;
            this.kode = kode;
            this.customer = customer;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }

        public static class_Customer cariCustomerById(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string kode = "SELECT * FROM customer WHERE id = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(kode, class_Database.koneksi);
            cmd.Parameters.AddWithValue("@id", id);
            da.SelectCommand = cmd;

            try
            {
                class_Database.open_connection();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                class_Database.close_connection();

                class_Customer customer;
                if (dt.Rows.Count > 0)
                {
                    string nama = dt.Rows[0][1].ToString();
                    string alamat = dt.Rows[0][2].ToString();
                    string zip_code = dt.Rows[0][3].ToString();
                    string phone_number = dt.Rows[0][4].ToString();
                    string email = dt.Rows[0][5].ToString();
                    customer = new class_Customer(Convert.ToInt16(id), nama, alamat, zip_code, phone_number, email);

                    return customer;
                }
                return null;
            }
            catch (Exception ex)
            {
                class_Database.close_connection();
                throw new Exception(ex.Message);
            }
        }

        public static class_Penjualan cari_kode(string kode)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql_query = "SELECT * FROM " + tabel + " WHERE kode = @kode";

            MySqlCommand cmd;
            cmd = new MySqlCommand(sql_query, class_Database.koneksi);
            cmd.Parameters.AddWithValue("@kode", kode);
            da.SelectCommand = cmd;
            try
            {
                class_Database.open_connection();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                class_Database.close_connection();

                class_Penjualan penjualan;
                if (dt.Rows.Count > 0)
                {
                    int id = Convert.ToInt16(dt.Rows[0][0]);
                    class_Customer customer = class_Penjualan.cariCustomerById(dt.Rows[0][2].ToString());
                    DateTime created_at = Convert.ToDateTime(dt.Rows[0][3]);
                    DateTime updated_at = Convert.ToDateTime(dt.Rows[0][4]);

                    penjualan = new class_Penjualan(id, kode, customer, created_at, updated_at);

                    return penjualan;
                }
                return null;
            }
            catch (Exception ex)
            {
                class_Database.close_connection();
                throw new Exception(ex.Message);
            }
        }

        public static class_Penjualan cari_id(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql_query = "SELECT * FROM " + tabel + " WHERE id = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(sql_query, class_Database.koneksi);
            cmd.Parameters.AddWithValue("@id", id);
            da.SelectCommand = cmd;
            try
            {
                class_Database.open_connection();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                class_Database.close_connection();

                class_Penjualan penjualan;
                if (dt.Rows.Count > 0)
                {
                    string kode = dt.Rows[0][1].ToString();
                    class_Customer customer = class_Penjualan.cariCustomerById(dt.Rows[0][2].ToString());
                    DateTime created_at = Convert.ToDateTime(dt.Rows[0][3]);
                    DateTime updated_at = Convert.ToDateTime(dt.Rows[0][4]);

                    penjualan = new class_Penjualan(Convert.ToInt16(id), kode, customer, created_at, updated_at);

                    return penjualan;
                }
                return null;
            }
            catch (Exception ex)
            {
                class_Database.close_connection();
                throw new Exception(ex.Message);
            }
        }

        public static string Select_CustomerName_byId(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql_query = "SELECT nama FROM customer WHERE id = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(sql_query, class_Database.koneksi);
            cmd.Parameters.AddWithValue("@id", id);
            da.SelectCommand = cmd;

            try
            {
                class_Database.open_connection();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                class_Database.close_connection();

                if (dt.Rows.Count > 0)
                {
                    string nama = dt.Rows[0][0].ToString();

                    return nama;
                }
                return "";
            }
            catch (Exception ex)
            {
                class_Database.close_connection();
                throw new Exception(ex.Message);
            }
        }

        public static class_Barang Select_Barang_dengan_Id(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql_query = "SELECT * FROM barang WHERE id = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(sql_query, class_Database.koneksi);
            cmd.Parameters.AddWithValue("@id", id);
            da.SelectCommand = cmd;

            try
            {
                class_Database.open_connection();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                class_Database.close_connection();

                class_Barang barang;
                if (dt.Rows.Count > 0)
                {
                    string kode = dt.Rows[0][1].ToString();
                    string nama = dt.Rows[0][2].ToString();
                    int jumlah = Convert.ToInt16(dt.Rows[0][3]);
                    decimal hargahpp = Convert.ToDecimal(dt.Rows[0][4]);
                    decimal hargajual = Convert.ToDecimal(dt.Rows[0][5]);

                    barang = new class_Barang(Convert.ToInt16(id), kode, nama, jumlah, hargahpp, hargajual);
                    return barang;
                }
                return null;
            }
            catch (Exception ex)
            {
                class_Database.close_connection();
                throw new Exception(ex.Message);
            }
        }
    }
}
