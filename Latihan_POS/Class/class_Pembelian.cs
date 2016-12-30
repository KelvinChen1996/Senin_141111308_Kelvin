using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_POS.Class
{
    class class_Pembelian
    {
        private static string tabel = "pembelian";
        
        public int id { private set; get; }
        public string kode { private set; get; }
        public class_Supplier supplier { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        public class_Pembelian(int id, string kode, class_Supplier supplier, DateTime created_at, DateTime updated_at)
        {
            this.id = id;
            this.kode = kode;
            this.supplier = supplier;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }

        public static class_Supplier cariSupplierById(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string kode = "SELECT * FROM supplier WHERE id = @id";

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

                class_Supplier supplier;
                if (dt.Rows.Count > 0)
                {
                    string nama = dt.Rows[0][1].ToString();
                    string alamat = dt.Rows[0][2].ToString();
                    string zip_code = dt.Rows[0][3].ToString();
                    string phone_number = dt.Rows[0][4].ToString();
                    string email = dt.Rows[0][5].ToString();
                    supplier = new class_Supplier(Convert.ToInt16(id),nama, alamat, zip_code, phone_number, email);

                    return supplier;
                }
                return null;
            }
            catch (Exception ex)
            {
                class_Database.close_connection();
                throw new Exception(ex.Message);
            }
        }

        public static class_Pembelian cari_kode(string kode)
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

                class_Pembelian pembelian;
                if (dt.Rows.Count > 0)
                {
                    int id = Convert.ToInt16(dt.Rows[0][0]);
                    class_Supplier supplier = class_Pembelian.cariSupplierById(dt.Rows[0][2].ToString());
                    DateTime created_at = Convert.ToDateTime(dt.Rows[0][3]);
                    DateTime updated_at = Convert.ToDateTime(dt.Rows[0][4]);

                    pembelian = new class_Pembelian(id, kode, supplier, created_at, updated_at);

                    return pembelian;
                }
                return null;
            }
            catch (Exception ex)
            {
                class_Database.close_connection();
                throw new Exception(ex.Message);
            }
        }

        public static class_Pembelian cari_id(string id)
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

                class_Pembelian pembelian;
                if (dt.Rows.Count > 0)
                {
                    string kode = dt.Rows[0][1].ToString();
                    class_Supplier supplier = class_Pembelian.cariSupplierById(dt.Rows[0][2].ToString());
                    DateTime created_at = Convert.ToDateTime(dt.Rows[0][3]);
                    DateTime updated_at = Convert.ToDateTime(dt.Rows[0][4]);

                    pembelian = new class_Pembelian(Convert.ToInt16(id), kode, supplier, created_at, updated_at);

                    return pembelian;
                }
                return null;
            }
            catch (Exception ex)
            {
                class_Database.close_connection();
                throw new Exception(ex.Message);
            }
        }

        public static string getSupplierNameById(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql_query = "SELECT nama FROM supplier WHERE id = @id";

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
