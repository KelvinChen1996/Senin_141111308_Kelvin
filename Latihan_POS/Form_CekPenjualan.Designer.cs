namespace Latihan_POS
{
    partial class Form_CekPenjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResetAll = new System.Windows.Forms.Button();
            this.cekBarang = new System.Windows.Forms.Button();
            this.cekCustomer = new System.Windows.Forms.Button();
            this.txtIdBarang = new System.Windows.Forms.TextBox();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtKuantitas = new System.Windows.Forms.TextBox();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.lblidbarang = new System.Windows.Forms.Label();
            this.lblidcust = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btntotal = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblket = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCekKode = new System.Windows.Forms.Button();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(478, 63);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(75, 23);
            this.btnResetAll.TabIndex = 13;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cekBarang
            // 
            this.cekBarang.Location = new System.Drawing.Point(196, 56);
            this.cekBarang.Name = "cekBarang";
            this.cekBarang.Size = new System.Drawing.Size(46, 23);
            this.cekBarang.TabIndex = 6;
            this.cekBarang.Text = "Cek";
            this.cekBarang.UseVisualStyleBackColor = true;
            this.cekBarang.Click += new System.EventHandler(this.cekBarang_Click);
            // 
            // cekCustomer
            // 
            this.cekCustomer.Location = new System.Drawing.Point(196, 29);
            this.cekCustomer.Name = "cekCustomer";
            this.cekCustomer.Size = new System.Drawing.Size(46, 23);
            this.cekCustomer.TabIndex = 5;
            this.cekCustomer.Text = "Cek";
            this.cekCustomer.UseVisualStyleBackColor = true;
            this.cekCustomer.Click += new System.EventHandler(this.cekCustomer_Click);
            // 
            // txtIdBarang
            // 
            this.txtIdBarang.Location = new System.Drawing.Point(77, 58);
            this.txtIdBarang.Name = "txtIdBarang";
            this.txtIdBarang.Size = new System.Drawing.Size(100, 20);
            this.txtIdBarang.TabIndex = 4;
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(77, 31);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtIdCustomer.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Id Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Id Customer";
            // 
            // btnsimpan
            // 
            this.btnsimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimpan.Location = new System.Drawing.Point(259, 31);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(109, 34);
            this.btnsimpan.TabIndex = 8;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(91, 61);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(139, 20);
            this.txtSubtotal.TabIndex = 7;
            // 
            // txtKuantitas
            // 
            this.txtKuantitas.Location = new System.Drawing.Point(91, 34);
            this.txtKuantitas.Name = "txtKuantitas";
            this.txtKuantitas.Size = new System.Drawing.Size(139, 20);
            this.txtKuantitas.TabIndex = 6;
            this.txtKuantitas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKuantitas_KeyUp);
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.Location = new System.Drawing.Point(91, 8);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.ReadOnly = true;
            this.txtHargaJual.Size = new System.Drawing.Size(139, 20);
            this.txtHargaJual.TabIndex = 5;
            // 
            // lblidbarang
            // 
            this.lblidbarang.AutoSize = true;
            this.lblidbarang.Location = new System.Drawing.Point(261, 61);
            this.lblidbarang.Name = "lblidbarang";
            this.lblidbarang.Size = new System.Drawing.Size(58, 13);
            this.lblidbarang.TabIndex = 8;
            this.lblidbarang.Text = "lblidbarang";
            this.lblidbarang.Visible = false;
            // 
            // lblidcust
            // 
            this.lblidcust.AutoSize = true;
            this.lblidcust.Location = new System.Drawing.Point(261, 34);
            this.lblidcust.Name = "lblidcust";
            this.lblidcust.Size = new System.Drawing.Size(45, 13);
            this.lblidcust.TabIndex = 7;
            this.lblidcust.Text = "lblidcust";
            this.lblidcust.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sub-total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Kuantitas";
            // 
            // btntotal
            // 
            this.btntotal.AutoSize = true;
            this.btntotal.Location = new System.Drawing.Point(31, 339);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(31, 13);
            this.btntotal.TabIndex = 10;
            this.btntotal.Text = "Total";
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(12, 132);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.Size = new System.Drawing.Size(936, 204);
            this.dgvDetail.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnsimpan);
            this.panel2.Controls.Add(this.txtSubtotal);
            this.panel2.Controls.Add(this.txtKuantitas);
            this.panel2.Controls.Add(this.txtHargaJual);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(569, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 101);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Harga Jual";
            // 
            // lblket
            // 
            this.lblket.AutoSize = true;
            this.lblket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblket.Location = new System.Drawing.Point(9, 9);
            this.lblket.Name = "lblket";
            this.lblket.Size = new System.Drawing.Size(46, 16);
            this.lblket.TabIndex = 0;
            this.lblket.Text = "lblket";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btntotal);
            this.panel1.Controls.Add(this.dgvDetail);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblidbarang);
            this.panel1.Controls.Add(this.lblidcust);
            this.panel1.Controls.Add(this.cekBarang);
            this.panel1.Controls.Add(this.cekCustomer);
            this.panel1.Controls.Add(this.txtIdBarang);
            this.panel1.Controls.Add(this.txtIdCustomer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblket);
            this.panel1.Location = new System.Drawing.Point(36, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 371);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // btnCekKode
            // 
            this.btnCekKode.Location = new System.Drawing.Point(388, 63);
            this.btnCekKode.Name = "btnCekKode";
            this.btnCekKode.Size = new System.Drawing.Size(75, 23);
            this.btnCekKode.TabIndex = 11;
            this.btnCekKode.Text = "Cek";
            this.btnCekKode.UseVisualStyleBackColor = true;
            this.btnCekKode.Click += new System.EventHandler(this.btnCekKode_Click);
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(192, 65);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(177, 20);
            this.txtKode.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kode";
            // 
            // Form_CekPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 532);
            this.ControlBox = false;
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCekKode);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label1);
            this.Name = "Form_CekPenjualan";
            this.Load += new System.EventHandler(this.frmPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button cekBarang;
        private System.Windows.Forms.Button cekCustomer;
        private System.Windows.Forms.TextBox txtIdBarang;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtKuantitas;
        private System.Windows.Forms.TextBox txtHargaJual;
        private System.Windows.Forms.Label lblidbarang;
        private System.Windows.Forms.Label lblidcust;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label btntotal;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCekKode;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label label1;
    }
}