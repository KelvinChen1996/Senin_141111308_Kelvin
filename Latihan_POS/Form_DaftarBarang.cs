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
    public partial class Form_DaftarBarang : MetroForm

    {
        static MySqlConnection koneksi = new MySqlConnection("Server=localhost;Port=3306;Database=latihan_pos;Uid=root;password=;");
        DataTable dtBarang;
        public Form_DaftarBarang()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmDaftarBarang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dtBarang = new DataTable();
            BindingSource bsBarang = new BindingSource();
            bsBarang.DataSource = dtBarang;
            dgvBarang.DataSource = bsBarang;
            lihatDaftarBarang();
        }

        private void lihatDaftarBarang()
        {
            try
            {
                dtBarang.Clear();
                Class.class_Barang.SelectAll().Fill(dtBarang);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void refresh_Click(object sender, EventArgs e)
        {
            lihatDaftarBarang();
        }
    }
}
