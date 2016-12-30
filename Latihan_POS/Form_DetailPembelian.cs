using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Latihan_POS
{
    public partial class Form_DetailPembelian : MetroForm
    {
        DataTable dtPembelian;
        DataTable dtDetailPembelian;
        public Form_DetailPembelian()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmDetailPembelian_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dtPembelian = new DataTable();
            BindingSource bsPembelian = new BindingSource();
            bsPembelian.DataSource = dtPembelian;
            dgvPembelian.DataSource = bsPembelian;

            dtDetailPembelian = new DataTable();
            BindingSource bsDetailPembelian = new BindingSource();
            bsDetailPembelian.DataSource = dtDetailPembelian;
            dgvDetailPembelian.DataSource = bsDetailPembelian;

            lihatDaftarPembelian();
            lihatDaftarDetailPembelian();
        }

        private void lihatDaftarPembelian()
        {
            try
            {
                dtPembelian.Clear();
                Class.class_DetailPembelian.SelectAllPembelian().Fill(dtPembelian);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void lihatDaftarDetailPembelian()
        {
            try
            {
                dtDetailPembelian.Clear();
                Class.class_DetailPembelian.SelectAllDetailPembelian().Fill(dtDetailPembelian);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lihatDaftarPembelian();
            lihatDaftarDetailPembelian();
        }
    }
}
