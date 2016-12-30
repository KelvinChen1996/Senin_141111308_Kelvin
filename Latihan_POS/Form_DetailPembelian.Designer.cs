namespace Latihan_POS
{
    partial class Form_DetailPembelian
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
            this.dgvPembelian = new System.Windows.Forms.DataGridView();
            this.lblpembelian = new System.Windows.Forms.Label();
            this.lbldetailpembelian = new System.Windows.Forms.Label();
            this.dgvDetailPembelian = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelian)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPembelian
            // 
            this.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembelian.Location = new System.Drawing.Point(43, 74);
            this.dgvPembelian.Name = "dgvPembelian";
            this.dgvPembelian.Size = new System.Drawing.Size(1183, 157);
            this.dgvPembelian.TabIndex = 0;
            // 
            // lblpembelian
            // 
            this.lblpembelian.AutoSize = true;
            this.lblpembelian.Location = new System.Drawing.Point(592, 41);
            this.lblpembelian.Name = "lblpembelian";
            this.lblpembelian.Size = new System.Drawing.Size(56, 13);
            this.lblpembelian.TabIndex = 1;
            this.lblpembelian.Text = "Pembelian";
            // 
            // lbldetailpembelian
            // 
            this.lbldetailpembelian.AutoSize = true;
            this.lbldetailpembelian.Location = new System.Drawing.Point(581, 260);
            this.lbldetailpembelian.Name = "lbldetailpembelian";
            this.lbldetailpembelian.Size = new System.Drawing.Size(86, 13);
            this.lbldetailpembelian.TabIndex = 2;
            this.lbldetailpembelian.Text = "Detail Pembelian";
            // 
            // dgvDetailPembelian
            // 
            this.dgvDetailPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPembelian.Location = new System.Drawing.Point(43, 283);
            this.dgvDetailPembelian.Name = "dgvDetailPembelian";
            this.dgvDetailPembelian.Size = new System.Drawing.Size(1183, 140);
            this.dgvDetailPembelian.TabIndex = 3;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(584, 446);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_DetailPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 501);
            this.ControlBox = false;
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.dgvDetailPembelian);
            this.Controls.Add(this.lbldetailpembelian);
            this.Controls.Add(this.lblpembelian);
            this.Controls.Add(this.dgvPembelian);
            this.Name = "Form_DetailPembelian";
            this.Load += new System.EventHandler(this.frmDetailPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPembelian;
        private System.Windows.Forms.Label lblpembelian;
        private System.Windows.Forms.Label lbldetailpembelian;
        private System.Windows.Forms.DataGridView dgvDetailPembelian;
        private System.Windows.Forms.Button btnrefresh;
    }
}