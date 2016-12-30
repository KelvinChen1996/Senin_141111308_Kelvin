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
    public partial class Form_CekPembelian : MetroForm
    {
        Class.class_Pembelian pembelian;
        Class.class_DetailPembelian detailPembelian;
        DataTable datatabel;
        string status_pembelian = "", status_barang = "";
        public Form_CekPembelian()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void kosongkan_semua()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            txtIdSupplier.Text = ""; txtIdSupplier.ReadOnly = false;
            txtIdBarang.Text = ""; txtIdBarang.ReadOnly = false;
            lblidsup.Visible = false; lblidbrg.Visible = false;
            txtKuantitas.Text = "";
            txtSubtotal.Text = "";
        }

        private void frmPembelian_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            datatabel = new DataTable();
            BindingSource bsDetail = new BindingSource();
            bsDetail.DataSource = datatabel;
            dgvDetail.DataSource = bsDetail;
        }

        private void lihatDetail(int id_pembelian)
        {
            try
            {
                datatabel.Clear();
                Class.class_DetailPembelian.SelectAllByIdPembelian(id_pembelian).Fill(datatabel);
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
            lbltotal.Text = string.Format("Total : Rp {0:N}", hsl);
        }

        private void btnCekKode_Click(object sender, EventArgs e)
        {
            pembelian = Class.class_Pembelian.cari_kode(txtKode.Text);
            kosongkan_semua();
            datatabel.Clear();

            if (pembelian == null)
            {
                lblket.Text = "Tambah Transaksi";
                status_pembelian = "insert";

                lbltotal.Text = "Total : Rp 0";
            }
            else
            {
                lblket.Text = "Edit Transaksi";
                txtIdSupplier.Text = pembelian.supplier.id.ToString();
                status_pembelian = "update";

                lihatDetail(pembelian.id);
            }

            panel1.Visible = true;
        }

        

        private void cekBarang_Click(object sender, EventArgs e)
        {
            lblidbrg.Visible = false;
            Class.class_Barang barang = Class.class_Pembelian.Select_Barang_dengan_Id(txtIdBarang.Text);
            {
                if (barang == null)
                {
                    lblidbrg.Text = "Tidak ditemukan !";
                    lblidbrg.Visible = true;
                }
                else
                {
                    txtIdBarang.ReadOnly = true;
                    lblidbrg.Text = "Nama Barang : " + barang.nama;
                    lblidbrg.Visible = true;
                    txtHargaHPP.Text = barang.harga_hpp.ToString();

                    if (pembelian != null)
                    {
                        detailPembelian = Class.class_DetailPembelian.cariDetailPembelian(pembelian.id.ToString(), barang.id.ToString());

                        if (detailPembelian != null)
                        {
                            txtKuantitas.Text = detailPembelian.kuantitas.ToString();
                            refresh_subtotal();
                            status_barang = "update";
                        }
                        else {
                            status_barang = "insert";
                        }
                    }

                    panel2.Visible = true;
                }
            }
        }

        private void cekSupplier_Click(object sender, EventArgs e)
        {
            lblidsup.Visible = false;
            string nama_supplier = Class.class_Pembelian.getSupplierNameById(txtIdSupplier.Text);
            if (nama_supplier != "")
            {
                lblidsup.Text = "Nama Supplier : " + nama_supplier;
                lblidsup.Visible = true;
                txtIdSupplier.ReadOnly = true;
            }
            else {
                lblidsup.Text = "Tidak Ditemukan !";
                lblidsup.Visible = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            kosongkan_semua();
            txtKode.Text = "";
        }

        private void refresh_subtotal()
        {
            decimal hasil;
            try
            {
                hasil = Convert.ToDecimal(txtHargaHPP.Text) * Convert.ToDecimal(txtKuantitas.Text);
                txtSubtotal.Text = hasil.ToString();
            }

            catch (Exception ex) { txtSubtotal.Text = ""; MessageBox.Show(ex.Message); }
        }

        private void txtKuantitas_KeyUp(object sender, KeyEventArgs e)
        {
            refresh_subtotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKuantitas.Text != "")
            {
                int res = Class.class_DetailPembelian.kelola_pembelian(status_pembelian, pembelian == null ? 0 : pembelian.id, pembelian == null ? txtKode.Text : pembelian.kode, Convert.ToInt16(txtIdSupplier.Text));
                string pesan;
                if (status_pembelian == "insert")
                    pesan = res.ToString() + " Pembelian berhasil ditambah";
                else
                    pesan = res.ToString() + " Pembelian berhasil diupdate";
                MessageBox.Show(pesan);

                int id_pembelian;
                if (pembelian == null)
                    id_pembelian = Class.class_DetailPembelian.last_id_pembelian();
                else
                    id_pembelian = pembelian.id;

                int kuantitas_awal = 0;
                if (detailPembelian != null)
                {
                    kuantitas_awal = detailPembelian.kuantitas;
                }

                int kuantitas_akhir = Convert.ToInt16(txtKuantitas.Text) - kuantitas_awal;
                Class.class_DetailPembelian.update_stok(Convert.ToInt16(txtIdBarang.Text), kuantitas_akhir);


                res = Class.class_DetailPembelian.kelola_detail_pembelian(status_barang, detailPembelian == null ? 0 : detailPembelian.id, id_pembelian, Convert.ToInt16(txtIdBarang.Text), Convert.ToDecimal(txtHargaHPP.Text), Convert.ToInt16(txtKuantitas.Text));
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
