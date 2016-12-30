using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace Latihan_POS
{
    public partial class Form_RegistrasiBarang : MetroForm
    {
        List<TextBox> list_txt = new List<TextBox>();
        public Form_RegistrasiBarang()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;         
        }

        private void kosongkan()
        {
            txtKode.Clear();
            txtNama.Clear();
            txtJlhAwal.Clear();
            txtHrgHPP.Clear();
            txtHargaJual.Clear();
            txtKode.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            kosongkan();
        }

        private void frmRegistrasiBarang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    list_txt.Add((TextBox) ctrl);
            }

            try
            {
                Class.class_Database.open_connection();
            }
            catch (MySqlException ec)
            {
                MessageBox.Show(ec.Message, "Error");
            }
        }

        private void frmRegistrasiBarang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Class.class_Database.close_connection();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Class.class_Database.close_connection();
            this.Close();
        }

        private bool validasi(List<TextBox> list)
        {
            bool v = true;
            foreach (TextBox item in list)
            {
                if (item.Text.Trim() == "")
                {
                    v = false;
                    break;
                }
            }
            return v;
        }

        private bool validasiKode(string teks)
        {
            MySqlCommand cmd = Class.class_Database.koneksi.CreateCommand();
            bool v = true;
            string query = "SELECT Kode from barang";
            cmd.CommandText = query;
            Class.class_Database.open_connection();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == teks)
                {
                    v = false;
                    break;
                }
            }
            Class.class_Database.close_connection();
            return v;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (validasi(list_txt))
            {
                if (validasiKode(txtKode.Text))
                {
                    try
                    {
                        Class.class_Barang BarangBaru = new Class.class_Barang(txtKode.Text, txtNama.Text, Convert.ToInt32(txtJlhAwal.Text), Convert.ToDecimal(txtHrgHPP.Text), Convert.ToDecimal(txtHargaJual.Text));
                        int res = BarangBaru.InsertBarang();
                        kosongkan();
                        MessageBox.Show(res + " produk berhasil ditambahkan", "Tersimpan");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                else {
                    MessageBox.Show("Kode yang diinput telah ada, silakan masukkan kode lain"); 
                }
            }
            else
            {
                MessageBox.Show("data belum lengkap, silakan lengkapi");
            }
        }

       
    }
}
