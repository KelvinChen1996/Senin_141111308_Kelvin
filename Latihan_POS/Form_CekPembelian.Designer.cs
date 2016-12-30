namespace Latihan_POS
{
    partial class Form_CekPembelian
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.btnCekKode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtKuantitas = new System.Windows.Forms.TextBox();
            this.txtHargaHPP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblidbrg = new System.Windows.Forms.Label();
            this.lblidsup = new System.Windows.Forms.Label();
            this.cekBarang = new System.Windows.Forms.Button();
            this.cekSupplier = new System.Windows.Forms.Button();
            this.txtIdBarang = new System.Windows.Forms.TextBox();
            this.txtIdSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblket = new System.Windows.Forms.Label();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(287, 50);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(177, 20);
            this.txtKode.TabIndex = 1;
            // 
            // btnCekKode
            // 
            this.btnCekKode.Location = new System.Drawing.Point(483, 48);
            this.btnCekKode.Name = "btnCekKode";
            this.btnCekKode.Size = new System.Drawing.Size(75, 23);
            this.btnCekKode.TabIndex = 2;
            this.btnCekKode.Text = "Cek";
            this.btnCekKode.UseVisualStyleBackColor = true;
            this.btnCekKode.Click += new System.EventHandler(this.btnCekKode_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.dgvDetail);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblidbrg);
            this.panel1.Controls.Add(this.lblidsup);
            this.panel1.Controls.Add(this.cekBarang);
            this.panel1.Controls.Add(this.cekSupplier);
            this.panel1.Controls.Add(this.txtIdBarang);
            this.panel1.Controls.Add(this.txtIdSupplier);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblket);
            this.panel1.Location = new System.Drawing.Point(11, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 357);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(13, 336);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 13);
            this.lbltotal.TabIndex = 10;
            this.lbltotal.Text = "Total";
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(12, 133);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.Size = new System.Drawing.Size(872, 189);
            this.dgvDetail.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnsimpan);
            this.panel2.Controls.Add(this.txtSubtotal);
            this.panel2.Controls.Add(this.txtKuantitas);
            this.panel2.Controls.Add(this.txtHargaHPP);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(472, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 96);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // btnsimpan
            // 
            this.btnsimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimpan.Location = new System.Drawing.Point(263, 25);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(109, 31);
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
            // txtHargaHPP
            // 
            this.txtHargaHPP.Location = new System.Drawing.Point(91, 8);
            this.txtHargaHPP.Name = "txtHargaHPP";
            this.txtHargaHPP.ReadOnly = true;
            this.txtHargaHPP.Size = new System.Drawing.Size(139, 20);
            this.txtHargaHPP.TabIndex = 5;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Harga HPP";
            // 
            // lblidbrg
            // 
            this.lblidbrg.AutoSize = true;
            this.lblidbrg.Location = new System.Drawing.Point(261, 61);
            this.lblidbrg.Name = "lblidbrg";
            this.lblidbrg.Size = new System.Drawing.Size(40, 13);
            this.lblidbrg.TabIndex = 8;
            this.lblidbrg.Text = "lblidbrg";
            this.lblidbrg.Visible = false;
            // 
            // lblidsup
            // 
            this.lblidsup.AutoSize = true;
            this.lblidsup.Location = new System.Drawing.Point(261, 34);
            this.lblidsup.Name = "lblidsup";
            this.lblidsup.Size = new System.Drawing.Size(42, 13);
            this.lblidsup.TabIndex = 7;
            this.lblidsup.Text = "lblidsup";
            this.lblidsup.Visible = false;
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
            // cekSupplier
            // 
            this.cekSupplier.Location = new System.Drawing.Point(196, 29);
            this.cekSupplier.Name = "cekSupplier";
            this.cekSupplier.Size = new System.Drawing.Size(46, 23);
            this.cekSupplier.TabIndex = 5;
            this.cekSupplier.Text = "Cek";
            this.cekSupplier.UseVisualStyleBackColor = true;
            this.cekSupplier.Click += new System.EventHandler(this.cekSupplier_Click);
            // 
            // txtIdBarang
            // 
            this.txtIdBarang.Location = new System.Drawing.Point(77, 58);
            this.txtIdBarang.Name = "txtIdBarang";
            this.txtIdBarang.Size = new System.Drawing.Size(100, 20);
            this.txtIdBarang.TabIndex = 4;
            // 
            // txtIdSupplier
            // 
            this.txtIdSupplier.Location = new System.Drawing.Point(77, 31);
            this.txtIdSupplier.Name = "txtIdSupplier";
            this.txtIdSupplier.Size = new System.Drawing.Size(100, 20);
            this.txtIdSupplier.TabIndex = 3;
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
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Id Supplier";
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
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(573, 48);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(75, 23);
            this.btnResetAll.TabIndex = 8;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form_CekPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCekKode);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label1);
            this.Name = "Form_CekPembelian";
            this.Load += new System.EventHandler(this.frmPembelian_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Button btnCekKode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblket;
        private System.Windows.Forms.Button cekBarang;
        private System.Windows.Forms.Button cekSupplier;
        private System.Windows.Forms.TextBox txtIdBarang;
        private System.Windows.Forms.TextBox txtIdSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblidsup;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Label lblidbrg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtKuantitas;
        private System.Windows.Forms.TextBox txtHargaHPP;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Label lbltotal;
    }
}