namespace Latihan_POS
{
    partial class Form_DetailPenjualan
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDetailPenjualan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldatapenjualan = new System.Windows.Forms.Label();
            this.dgvPenjualan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDetailPenjualan
            // 
            this.dgvDetailPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPenjualan.Location = new System.Drawing.Point(23, 286);
            this.dgvDetailPenjualan.Name = "dgvDetailPenjualan";
            this.dgvDetailPenjualan.Size = new System.Drawing.Size(1214, 143);
            this.dgvDetailPenjualan.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detail Penjualan";
            // 
            // lbldatapenjualan
            // 
            this.lbldatapenjualan.AutoSize = true;
            this.lbldatapenjualan.Location = new System.Drawing.Point(580, 35);
            this.lbldatapenjualan.Name = "lbldatapenjualan";
            this.lbldatapenjualan.Size = new System.Drawing.Size(80, 13);
            this.lbldatapenjualan.TabIndex = 6;
            this.lbldatapenjualan.Text = "Data Penjualan";
            // 
            // dgvPenjualan
            // 
            this.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenjualan.Location = new System.Drawing.Point(32, 63);
            this.dgvPenjualan.Name = "dgvPenjualan";
            this.dgvPenjualan.Size = new System.Drawing.Size(1205, 143);
            this.dgvPenjualan.TabIndex = 5;
            // 
            // Form_DetailPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 590);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDetailPenjualan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldatapenjualan);
            this.Controls.Add(this.dgvPenjualan);
            this.Name = "Form_DetailPenjualan";
            this.Load += new System.EventHandler(this.frmDetailPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDetailPenjualan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldatapenjualan;
        private System.Windows.Forms.DataGridView dgvPenjualan;
    }
}