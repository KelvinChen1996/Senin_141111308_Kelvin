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
    public partial class Form_CekPenjualan : MetroForm
    {
        Class.class_Penjualan penjualan;
        Class.class_DetailPenjualan detailPenjualan;
        DataTable datatabel;
        string status_penjualan = "", status_barang = "";
        public Form_CekPenjualan()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmPenjualan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            datatabel = new DataTable();
            BindingSource bsDetail = new BindingSource();
            bsDetail.DataSource = datatabel;
            dgvDetail.DataSource = bsDetail;
        }

        private void lihatDetail(int id_penjualan)
        {
            try
            {
                datatabel.Clear();
                Class.class_DetailPenjualan.SelectAllByIdPenjualan(id_penjualan).Fill(datatabel);
                refresh_total();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void refresh_total()
        {
            decimal hsl = 0;
            foreach (DataGridViewRow i in dgvDetail.Rows)
            {
                hsl += Convert.ToDecimal(i.Cells["harga_barang"].Value) * Convert.ToDecimal(i.Cells["kuantitas"].Value);
            }
            btntotal.Text = string.Format("Total : Rp {0:N}", hsl);
        }

        private void btnCekKode_Click(object sender, EventArgs e)
        {
            penjualan = Class.class_Penjualan.cari_kode(txtKode.Text);
            kosongkan_semua();
            datatabel.Clear();

            if (penjualan == null)
            {
                lblket.Text = "Tambah Transaksi";
                status_penjualan = "insert";

                btntotal.Text = "Total : Rp 0";
            }
            else
            {
                lblket.Text = "Edit Transaksi";
                txtIdCustomer.Text = penjualan.customer.id.ToString();
                status_penjualan = "update";

                lihatDetail(penjualan.id);
            }

            panel1.Visible = true;
        }

        private void kosongkan_semua()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            txtIdCustomer.Text = ""; txtIdCustomer.ReadOnly = false;
            txtIdBarang.Text = ""; txtIdBarang.ReadOnly = false;
            lblidcust.Visible = false; lblidbarang.Visible = false;
            txtKuantitas.Text = "";
            txtSubtotal.Text = "";
        }

        private void cekBarang_Click(object sender, EventArgs e)
        {
            lblidbarang.Visible = false;
            Class.class_Barang barang = Class.class_Penjualan.Select_Barang_dengan_Id(txtIdBarang.Text);
            {
                if (barang == null)
                {
                    lblidbarang.Text = "Tidak ditemukan !";
                    lblidbarang.Visible = true;
                }
                else
                {
                    txtIdBarang.ReadOnly = true;
                    lblidbarang.Text = "Nama Barang : " + barang.nama;
                    lblidbarang.Visible = true;
                    txtHargaJual.Text = barang.harga_jual.ToString();

                    if (penjualan != null)
                    {
                        detailPenjualan = Class.class_DetailPenjualan.cariDetailPenjualan(penjualan.id.ToString(), barang.id.ToString());

                        if (detailPenjualan != null)
                        {
                            txtKuantitas.Text = detailPenjualan.kuantitas.ToString();
                            refresh_subtotal();
                            status_barang = "update";
                        }
                        else
                        {
                            status_barang = "insert";
                        }
                    }

                    panel2.Visible = true;
                }
            }
        }

        private void refresh_subtotal()
        {
            decimal hasil;
            try
            {
                hasil = Convert.ToDecimal(txtHargaJual.Text) * Convert.ToDecimal(txtKuantitas.Text);
                txtSubtotal.Text = hasil.ToString();
            }

            catch (Exception ex) { txtSubtotal.Text = ""; MessageBox.Show(ex.Message); }
        }

        private void cekCustomer_Click(object sender, EventArgs e)
        {
            lblidcust.Visible = false;
            string nama_customer = Class.class_Penjualan.Select_CustomerName_byId(txtIdCustomer.Text);
            if (nama_customer != "")
            {
                lblidcust.Text = "Nama Customer : " + nama_customer;
                lblidcust.Visible = true;
                txtIdCustomer.ReadOnly = true;
            }
            else
            {
                lblidcust.Text = "Tidak Ditemukan !";
                lblidcust.Visible = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            kosongkan_semua();
            txtKode.Text = "";
        }

        private void txtKuantitas_KeyUp(object sender, KeyEventArgs e)
        {
            refresh_subtotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKuantitas.Text != "")
            {
                int res = Class.class_DetailPenjualan.kelola_penjualan(status_penjualan, penjualan == null ? 0 : penjualan.id, penjualan == null ? txtKode.Text : penjualan.kode, Convert.ToInt16(txtIdCustomer.Text));
                string pesan;
                if (status_penjualan == "insert")
                    pesan = res.ToString() + " Penjualan berhasil ditambah";
                else
                    pesan = res.ToString() + " Penjualan berhasil diupdate";
                MessageBox.Show(pesan);

                int id_penjualan;
                if (penjualan == null)
                    id_penjualan = Class.class_DetailPenjualan.last_id_penjualan();
                else
                    id_penjualan = penjualan.id;

                int kuantitas_awal = 0;
                if (detailPenjualan != null)
                {
                    kuantitas_awal = detailPenjualan.kuantitas;
                }

                int kuantitas_akhir = Convert.ToInt16(txtKuantitas.Text) - kuantitas_awal;
                Class.class_DetailPenjualan.update_stok(Convert.ToInt16(txtIdBarang.Text), kuantitas_akhir);


                res = Class.class_DetailPenjualan.kelola_detail_penjualan(status_barang, detailPenjualan == null ? 0 : detailPenjualan.id, id_penjualan, Convert.ToInt16(txtIdBarang.Text), Convert.ToDecimal(txtHargaJual.Text), Convert.ToInt16(txtKuantitas.Text));
                if (status_barang == "insert")
                    pesan = res.ToString() + " Barang berhasil ditambah";
                else
                    pesan = res.ToString() + " Barang berhasil diupdate";
                MessageBox.Show(pesan);

                kosongkan_semua();
            }
        }    

    }
}
