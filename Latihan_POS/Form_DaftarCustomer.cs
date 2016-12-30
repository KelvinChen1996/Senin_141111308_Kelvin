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
    public partial class Form_DaftarCustomer : MetroForm
    {
        DataTable dataCust;
        public Form_DaftarCustomer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmDaftarCustomer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataCust = new DataTable();
            BindingSource bsCustomer = new BindingSource();
            bsCustomer.DataSource = dataCust;
            dgvCustomer.DataSource = bsCustomer;
            lihatDaftarCustomer();
        }

        private void lihatDaftarCustomer()
        {

            try
            {
                dataCust.Clear();
                Class.class_Customer.SelectAll().Fill(dataCust);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            lihatDaftarCustomer();
        }
    }
}
