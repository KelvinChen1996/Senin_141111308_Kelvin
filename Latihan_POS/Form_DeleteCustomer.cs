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
    public partial class Form_DeleteCustomer : MetroForm
    {
        public Form_DeleteCustomer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmDeleteCustomer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                int res;
                DialogResult rslt;
                rslt = MessageBox.Show("Apakah Anda yakin ?", "Yakin?", MessageBoxButtons.YesNo);

                if (rslt == DialogResult.Yes)
                {
                    Class.class_Customer CustomerHapus = new Class.class_Customer(Convert.ToInt16(txtId.Text));
                    res = CustomerHapus.DeleteCustomer();
                    txtId.Text = "";
                    MessageBox.Show("Customer telah berhasil dihapus", "Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
