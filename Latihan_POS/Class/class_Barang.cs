using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Latihan_POS.Class
{
    class class_Barang
    {
        private static string tabel = "barang";
        public int id { private set; get; }
        public string kode { private set; get; }
        public string nama { private set; get; }
        public int jumlah { private set; get; }
        public decimal harga_hpp { private set; get; }
        public decimal harga_jual { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        public class_Barang()
        { 
            
        }

        public class_Barang(int id)
        {
            this.id = id;
        }

        public class_Barang(int id, string kode, string nama, int jumlah, decimal harga_hpp, decimal harga_jual)
        {
            this.id = id;
            this.kode = kode;
            this.nama = nama;
            this.jumlah = jumlah;
            this.harga_hpp = harga_hpp;
            this.harga_jual = harga_jual;
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }
        
        public class_Barang(string kode, string nama, int jumlah, decimal harga_hpp, decimal harga_jual)
        {
            this.kode = kode;
            this.nama = nama;
            this.jumlah = jumlah;
            this.harga_hpp = harga_hpp;
            this.harga_jual = harga_jual;
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }

        public static MySqlDataAdapter SelectAll()
        {
            class_Database.open_connection();

            MySqlDataAdapter da;
            string selectQuery = "SELECT * FROM " + tabel;
            da = new MySqlDataAdapter(selectQuery, class_Database.koneksi);
            da.SelectCommand.ExecuteScalar();

            class_Database.close_connection();
            return da;
        }

        public int InsertBarang()
        {
            int res;
            class_Database.open_connection();

            MySqlDataAdapter da = new MySqlDataAdapter();
            string insertQuery = "INSERT INTO " + tabel + " (kode,nama,JumlahAwal,HargaHPP,HargaJual,created_at,updated_at)";
            insertQuery += " VALUES (@kode,@nama,@jumlahAwal,@hargaHPP,@hargaJual,@createdAt,@updatedAt)";

            MySqlCommand cmd;
            cmd = new MySqlCommand(insertQuery, class_Database.koneksi);
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@jumlahAwal", jumlah);
            cmd.Parameters.AddWithValue("@hargaHPP", harga_hpp);
            cmd.Parameters.AddWithValue("@hargaJual", harga_jual);
            cmd.Parameters.AddWithValue("@createdAt", created_at);
            cmd.Parameters.AddWithValue("@updatedAt", updated_at);

            da.InsertCommand = cmd;
            res = da.InsertCommand.ExecuteNonQuery();

            class_Database.close_connection();
            return res;
        }

        public static Dictionary<string,string> cariBarang(string id_barang)
        {
            Dictionary<string, string> hasil = new Dictionary<string, string>();
            MySqlCommand cmd = class_Database.koneksi.CreateCommand();
            string query = "SELECT * from barang WHERE id=" + id_barang;
            cmd.CommandText = query;
            class_Database.open_connection();
            MySqlDataReader reader = cmd.ExecuteReader();
            hasil["tersedia"] = "tidak tersedia";
            while (reader.Read())
            {
                hasil["tersedia"] = "tersedia";
                hasil["kode"] = reader.GetString("kode");
                hasil["nama"] = reader.GetString("nama");
                hasil["jumlahawal"] = reader.GetString("JumlahAwal");
                hasil["hargahpp"] = reader.GetString("HargaHPP");
                hasil["hargajual"] = reader.GetString("HargaJual");
            }
            class_Database.close_connection();

            return hasil;
        }

        public int UpdateBarang(int id, string kode, string nama, int jumlah, decimal harga_hpp, decimal harga_jual)
        {
            int res;
            class_Database.open_connection();

            MySqlDataAdapter da = new MySqlDataAdapter();
            string update = "UPDATE " + tabel + " SET kode = @kode, nama = @nama, JumlahAwal = @jumlahAwal, HargaHPP = @hargaHPP, ";
            update += "HargaJual = @hargaJual, updated_at = @updatedAt WHERE id = @id";
            updated_at = DateTime.Now;
            MySqlCommand cmd;
            cmd = new MySqlCommand(update, class_Database.koneksi);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@jumlahAwal", jumlah);
            cmd.Parameters.AddWithValue("@hargaHPP", harga_hpp);
            cmd.Parameters.AddWithValue("@hargaJual", harga_jual);
            cmd.Parameters.AddWithValue("@updatedAt", updated_at);

            da.UpdateCommand = cmd;
            res = da.UpdateCommand.ExecuteNonQuery();

            class_Database.close_connection();
            return res;
        }

        public int DeleteBarang()
        {
            int res;
            class_Database.open_connection();

            MySqlDataAdapter da = new MySqlDataAdapter();
            string delete = "DELETE FROM barang WHERE id = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(delete, class_Database.koneksi);
            cmd.Parameters.AddWithValue("@id", id);

            da.DeleteCommand = cmd;
            res = da.DeleteCommand.ExecuteNonQuery();

            class_Database.close_connection();
            return res;
        }
    }
}
