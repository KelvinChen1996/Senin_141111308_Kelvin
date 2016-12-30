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
    public partial class Form_DaftarSupplier : MetroForm

    {
        DataTable dtSupplier;
        public Form_DaftarSupplier()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmDaftarSupplier_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dtSupplier = new DataTable();
            BindingSource bsSupplier = new BindingSource();
            bsSupplier.DataSource = dtSupplier;
            dgvSupplier.DataSource = bsSupplier;
            lihatDaftarSupplier();
        }

        private void lihatDaftarSupplier()
        {
            try
            {
                dtSupplier.Clear();
                Class.class_Supplier.SelectAll().Fill(dtSupplier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            lihatDaftarSupplier();
        }
    }
}
