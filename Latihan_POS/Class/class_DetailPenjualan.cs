using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Latihan_POS.Class
{
    class class_DetailPenjualan
    {
        private static string tabel = "penjualan_detail";

        public int id { private set; get; }
        public class_Penjualan penjualan { private set; get; }
        public class_Barang barang { private set; get; }
        public decimal harga_barang { private set; get; }
        public int kuantitas { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        public class_DetailPenjualan(int id, class_Penjualan penjualan, class_Barang barang, decimal harga_barang, int kuantitas, DateTime create, DateTime update)
        {
            this.id = id;
            this.penjualan = penjualan;
            this.barang = barang;
            this.harga_barang = harga_barang;
            this.kuantitas = kuantitas;
            this.created_at = create;
            this.updated_at = update;
        }

        public static class_DetailPenjualan cariDetailPenjualan(string id_penjualan, string id_barang)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string kode = "SELECT * FROM " + tabel + " WHERE id_penjualan = @id_penjualan AND id_barang = @id_barang";

            MySqlCommand cmd;
            cmd = new MySqlCommand(kode, class_Database.koneksi);
            cmd.Parameters.AddWithValue("@id_penjualan", id_penjualan);
            cmd.Parameters.AddWithValue("@id_barang", id_barang);
            da.SelectCommand = cmd;
            try
            {
                class_Database.open_connection();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                class_Database.close_connection();

                class_DetailPenjualan detailPenjualan;
                if (dt.Rows.Count > 0)
                {
                    int id = Convert.ToInt16(dt.Rows[0][0]);
                    class_Penjualan penjualan = class_Penjualan.cari_id(dt.Rows[0][1].ToString());
                    class_Barang barang = class_Penjualan.Select_Barang_dengan_Id(dt.Rows[0][2].ToString());
                    decimal harga_barang = Convert.ToDecimal(dt.Rows[0][3]);
                    int kuantitas = Convert.ToInt16(dt.Rows[0][4]);
                    DateTime create = Convert.ToDateTime(dt.Rows[0][5]);
                    DateTime update = Convert.ToDateTime(dt.Rows[0][6]);

                    detailPenjualan = new class_DetailPenjualan(id, penjualan, barang, harga_barang, kuantitas, create, update);

                    return detailPenjualan;
                }
                return null;
            }
            catch (Exception ex)
            {
                class_Database.close_connection();
                throw new Exception(ex.Message);
            }
        }

        public static int last_id_penjualan()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string kode = "SELECT LAST id FROM penjualan";

            MySqlCommand cmd;
            cmd = new MySqlCommand(kode, class_Database.koneksi);
            da.SelectCommand = cmd;
            try
            {
                class_Database.open_connection();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                class_Database.close_connection();

                int hasil;
                if (dt.Rows.Count > 0)
                {
                    hasil = Convert.ToInt16(dt.Rows[0][0]);
                    return hasil;
                }
                return -1;
            }
            catch (Exception ex)
            {
                class_Database.close_connection();
                throw new Exception(ex.Message);
            }
        }

        public static int kelola_penjualan(string command, int id, string kode, int id_customer)
        {
            int res = 0;
            if (command == "insert")
            {
                class_Database.open_connection();

                MySqlDataAdapter da = new MySqlDataAdapter();
                string insertQuery = "INSERT INTO penjualan (kode,id_customer,created_at,updated_at)";
                insertQuery += " VALUES (@kode,@id_customer,@createdAt,@updatedAt)";

                MySqlCommand cmd;
                DateTime created_at = DateTime.Now;
                DateTime updated_at = DateTime.Now;
                cmd = new MySqlCommand(insertQuery, class_Database.koneksi);
                cmd.Parameters.AddWithValue("@kode", kode);
                cmd.Parameters.AddWithValue("@id_customer", id_customer);
                cmd.Parameters.AddWithValue("@createdAt", created_at);
                cmd.Parameters.AddWithValue("@updatedAt", updated_at);

                da.InsertCommand = cmd;
                res = da.InsertCommand.ExecuteNonQuery();

                class_Database.close_connection();
                return res;
            }
            else
            {
                class_Database.open_connection();

                MySqlDataAdapter da = new MySqlDataAdapter();
                string update = "UPDATE penjualan SET kode = @kode, id_customer = @id_customer, ";
                update += "updated_at = @updatedAt WHERE ID = @id";
                DateTime updated_at = DateTime.Now;

                MySqlCommand cmd;
                cmd = new MySqlCommand(update, class_Database.koneksi);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@kode", kode);
                cmd.Parameters.AddWithValue("@id_customer", id_customer);
                cmd.Parameters.AddWithValue("@updatedAt", updated_at);

                da.UpdateCommand = cmd;
                res = da.UpdateCommand.ExecuteNonQuery();

                class_Database.close_connection();
                return res;
            }
        }

        public static int kelola_detail_penjualan(string command, int id, int id_penjualan, int id_barang, decimal harga_barang, int kuantitas)
        {
            int res = 0;
            if (command == "insert")
            {
                class_Database.open_connection();

                MySqlDataAdapter da = new MySqlDataAdapter();
                string insertQuery = "INSERT INTO penjualan_detail (id_penjualan, id_barang, harga_barang, kuantitas ,created_at,updated_at)";
                insertQuery += " VALUES (@id_penjualan, @id_barang, @harga_barang, @kuantitas ,@createdAt,@updatedAt)";

                MySqlCommand cmd;
                DateTime created_at = DateTime.Now;
                DateTime updated_at = DateTime.Now;
                cmd = new MySqlCommand(insertQuery, class_Database.koneksi);
                cmd.Parameters.AddWithValue("@id_penjualan", id_penjualan);
                cmd.Parameters.AddWithValue("@id_barang", id_barang);
                cmd.Parameters.AddWithValue("@harga_barang", harga_barang);
                cmd.Parameters.AddWithValue("@kuantitas", kuantitas);
                cmd.Parameters.AddWithValue("@createdAt", created_at);
                cmd.Parameters.AddWithValue("@updatedAt", updated_at);

                da.InsertCommand = cmd;
                res = da.InsertCommand.ExecuteNonQuery();

                class_Database.close_connection();
                return res;
            }
            else
            {
                class_Database.open_connection();

                MySqlDataAdapter da = new MySqlDataAdapter();
                string update = "UPDATE penjualan_detail SET id_penjualan=@id_penjualan, id_barang=@id_barang, harga_barang=@harga_barang, kuantitas=@kuantitas, ";
                update += "updated_at = @updatedAt WHERE ID = @id";
                DateTime updated_at = DateTime.Now;

                MySqlCommand cmd;
                cmd = new MySqlCommand(update, class_Database.koneksi);
                cmd.Parameters.AddWithValue("@id_penjualan", id_penjualan);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@id_barang", id_barang);
                cmd.Parameters.AddWithValue("@harga_barang", harga_barang);
                cmd.Parameters.AddWithValue("@kuantitas", kuantitas);
                cmd.Parameters.AddWithValue("@updatedAt", updated_at);

                da.UpdateCommand = cmd;
                res = da.UpdateCommand.ExecuteNonQuery();

                class_Database.close_connection();
                return res;
            }
        }

        public static void update_stok(int id_barang, int selisih_kuantitas)
        {
            class_Database.open_connection();
            int res;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string update = "UPDATE barang SET JumlahAwal=JumlahAwal - @selisih_kuantitas, ";
            update += "updated_at = @updatedAt WHERE ID = @id";
            DateTime updated_at = DateTime.Now;

            MySqlCommand cmd;
            cmd = new MySqlCommand(update, class_Database.koneksi);
            cmd.Parameters.AddWithValue("@selisih_kuantitas", selisih_kuantitas);
            cmd.Parameters.AddWithValue("@updatedAt", updated_at);
            cmd.Parameters.AddWithValue("@id", id_barang);

            da.UpdateCommand = cmd;
            res = da.UpdateCommand.ExecuteNonQuery();

            class_Database.close_connection();
        }

        public static MySqlDataAdapter SelectAllByIdPenjualan(int id_penjualan)
        {
            class_Database.open_connection();

            MySqlDataAdapter da;
            string selectQuery = "SELECT * FROM " + tabel + " WHERE id_penjualan= " + id_penjualan.ToString();
            da = new MySqlDataAdapter(selectQuery, class_Database.koneksi);
            da.SelectCommand.ExecuteScalar();

            class_Database.close_connection();
            return da;
        }

        public static MySqlDataAdapter SelectAllPenjualan()
        {
            class_Database.open_connection();

            MySqlDataAdapter da;
            string selectQuery = "SELECT * FROM penjualan";
            da = new MySqlDataAdapter(selectQuery, class_Database.koneksi);
            da.SelectCommand.ExecuteScalar();

            class_Database.close_connection();
            return da;
        }

        public static MySqlDataAdapter SelectAllDetailPenjualan()
        {
            class_Database.open_connection();

            MySqlDataAdapter da;
            string selectQuery = "SELECT * FROM penjualan_detail";
            da = new MySqlDataAdapter(selectQuery, class_Database.koneksi);
            da.SelectCommand.ExecuteScalar();

            class_Database.close_connection();
            return da;
        }
    }
}
