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
    public partial class Form_EditSupplier : MetroForm
    {
        public Form_EditSupplier()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmEditSupplier_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            string teks = txtId.Text;
            if (teks.Trim() != "")
            {
                try
                {
                    Dictionary<string, string> hasil = Class.class_Supplier.cariSupplier(teks);
                    if (hasil["tersedia"] == "tersedia")
                    {
                        txtIdInner.Text = teks;
                        txtNama.Text = hasil["nama"];
                        txtAlamat.Text = hasil["alamat"];
                        txtZipcode.Text = hasil["zipcode"];
                        txtPhoneNumber.Text = hasil["phonenumber"];
                        txtEmail.Text = hasil["email"];
                        panel1.Visible = true;
                    }
                    else
                    {
                        panel1.Visible = false;
                        MessageBox.Show("ID tidak ditemukan");
                    }
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Class.class_Database.close_connection();
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Class.class_Supplier SupplierEdit = new Class.class_Supplier();
                int res = SupplierEdit.UpdateSupplier(Convert.ToInt16(txtIdInner.Text), txtNama.Text, txtAlamat.Text, txtZipcode.Text, txtPhoneNumber.Text, txtEmail.Text);
                MessageBox.Show("Informasi Supplier berhasil diubah", "Edited");
                panel1.Visible = false;
                txtId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
