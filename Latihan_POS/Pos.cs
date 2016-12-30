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
    public partial class Pos : MetroForm
    {
        Form_RegistrasiBarang form_RegistrasiBarang;
        Form_RegistrasiCustomer form_RegistrasiCustomer;
        Form_RegistrasiSupplier form_RegistrasiSupplier;
        Form_EditBarang form_EditBarang;
        Form_EditCustomer form_EditCustomer;
        Form_EditSupplier form_EditSupplier;
        Form_DeleteBarang form_DeleteBarang;
        Form_DeleteCustomer form_DeleteCustomer;
        Form_DeleteSupplier form_DeleteSupplier;
        Form_DaftarBarang form_DaftarBarang;
        Form_DaftarCustomer form_DaftarCustomer;
        Form_DaftarSupplier form_DaftarSupplier;
        Form_CekPembelian form_Pembelian;
        Form_DetailPembelian form_DetailPembelian;
        Form_CekPenjualan form_Penjualan;
        Form_DetailPenjualan form_DetailPenjualan;

        public Pos()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (form_RegistrasiBarang == null || !form_RegistrasiBarang.IsHandleCreated)
            {
                form_RegistrasiBarang = new Form_RegistrasiBarang();
                form_RegistrasiBarang.MdiParent = this;
            }
            form_RegistrasiBarang.BringToFront();
            form_RegistrasiBarang.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_RegistrasiCustomer == null || !form_RegistrasiCustomer.IsHandleCreated)
            {
                form_RegistrasiCustomer = new Form_RegistrasiCustomer();
                form_RegistrasiCustomer.MdiParent = this;
            }
            form_RegistrasiCustomer.BringToFront();
            form_RegistrasiCustomer.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_RegistrasiSupplier == null || !form_RegistrasiSupplier.IsHandleCreated)
            {
                form_RegistrasiSupplier = new Form_RegistrasiSupplier();
                form_RegistrasiSupplier.MdiParent = this;
            }
            form_RegistrasiSupplier.BringToFront();
            form_RegistrasiSupplier.Show();
        }


        private void barangToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (form_EditBarang == null || !form_EditBarang.IsHandleCreated)
            {
                form_EditBarang = new Form_EditBarang();
                form_EditBarang.MdiParent = this;
            }
            form_EditBarang.BringToFront();
            form_EditBarang.Show();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (form_EditCustomer == null || !form_EditCustomer.IsHandleCreated)
            {
                form_EditCustomer = new Form_EditCustomer();
                form_EditCustomer.MdiParent = this;
            }
            form_EditCustomer.BringToFront();
            form_EditCustomer.Show();
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (form_EditSupplier == null || !form_EditSupplier.IsHandleCreated)
            {
                form_EditSupplier = new Form_EditSupplier();
                form_EditSupplier.MdiParent = this;
            }
            form_EditSupplier.BringToFront();
            form_EditSupplier.Show();
        }

        private void barangToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (form_DeleteBarang == null || !form_DeleteBarang.IsHandleCreated)
            {
                form_DeleteBarang = new Form_DeleteBarang();
                form_DeleteBarang.MdiParent = this;
            }
            form_DeleteBarang.BringToFront();
            form_DeleteBarang.Show();
        }

        private void customerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (form_DeleteCustomer == null || !form_DeleteCustomer.IsHandleCreated)
            {
                form_DeleteCustomer = new Form_DeleteCustomer();
                form_DeleteCustomer.MdiParent = this;
            }
            form_DeleteCustomer.BringToFront();
            form_DeleteCustomer.Show();
        }

        private void supplierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (form_DeleteSupplier == null || !form_DeleteSupplier.IsHandleCreated)
            {
                form_DeleteSupplier = new Form_DeleteSupplier();
                form_DeleteSupplier.MdiParent = this;
            }
            form_DeleteSupplier.BringToFront();
            form_DeleteSupplier.Show();
        }

        private void barangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (form_DaftarBarang == null || !form_DaftarBarang.IsHandleCreated)
            {
                form_DaftarBarang = new Form_DaftarBarang();
                form_DaftarBarang.MdiParent = this;
            }
            form_DaftarBarang.BringToFront();
            form_DaftarBarang.Show();
        }

        private void customerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (form_DaftarCustomer == null || !form_DaftarCustomer.IsHandleCreated)
            {
                form_DaftarCustomer = new Form_DaftarCustomer();
                form_DaftarCustomer.MdiParent = this;
            }
            form_DaftarCustomer.BringToFront();
            form_DaftarCustomer.Show();
        }

        private void supplierToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (form_DaftarSupplier == null || !form_DaftarSupplier.IsHandleCreated)
            {
                form_DaftarSupplier = new Form_DaftarSupplier();
                form_DaftarSupplier.MdiParent = this;
            }
            form_DaftarSupplier.BringToFront();
            form_DaftarSupplier.Show();
        }


        private void cekPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_Pembelian == null || !form_Pembelian.IsHandleCreated)
            {
                form_Pembelian = new Form_CekPembelian();
                form_Pembelian.MdiParent = this;
            }
            form_Pembelian.BringToFront();
            form_Pembelian.Show();
        }

        private void detailPembelianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (form_DetailPembelian == null || !form_DetailPembelian.IsHandleCreated)
            {
                form_DetailPembelian = new Form_DetailPembelian();
                form_DetailPembelian.MdiParent = this;
            }
            form_DetailPembelian.BringToFront();
            form_DetailPembelian.Show();
        }

        private void cekPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_Penjualan == null || !form_Penjualan.IsHandleCreated)
            {
                form_Penjualan = new Form_CekPenjualan();
                form_Penjualan.MdiParent = this;
            }
            form_Penjualan.BringToFront();
            form_Penjualan.Show();
        }

        private void detailPenjualanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (form_DetailPenjualan == null || !form_DetailPenjualan.IsHandleCreated)
            {
                form_DetailPenjualan = new Form_DetailPenjualan();
                form_DetailPenjualan.MdiParent = this;
            }
            form_DetailPenjualan.BringToFront();
            form_DetailPenjualan.Show();
        }

        private void Pos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Pos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
        
    }
}
