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
    public partial class Form_RegistrasiCustomer : MetroForm
    {
        List<TextBox> list_txt = new List<TextBox>();
        public Form_RegistrasiCustomer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void kosongkan()
        {
            txtZipcode.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
        }

        private void frmRegistrasiCustomer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    list_txt.Add((TextBox)ctrl);
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

        
        private void btnReset_Click(object sender, EventArgs e)
        {
            kosongkan();
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (validasi(list_txt))
            {
                
                try
                {
                    Class.class_Customer CustomerBaru = new Class.class_Customer(txtNama.Text, txtAlamat.Text, txtZipcode.Text, txtPhoneNumber.Text, txtEmail.Text);
                    int res = CustomerBaru.InsertCustomer();
                    kosongkan();
                    MessageBox.Show(res + " Customer berhasil ditambahkan", "Tersimpan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
                
            else
            {
                MessageBox.Show("data belum lengkap, silakan lengkapi");
            }
        }
    }
}
