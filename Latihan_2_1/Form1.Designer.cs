namespace Latihan_2_1
{
    partial class Form1
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
            this.nudtanggal = new System.Windows.Forms.NumericUpDown();
            this.dudbulan = new System.Windows.Forms.DomainUpDown();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.nudtanggal)).BeginInit();
            this.SuspendLayout();
            // 
            // nudtanggal
            // 
            this.nudtanggal.Location = new System.Drawing.Point(26, 25);
            this.nudtanggal.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudtanggal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudtanggal.Name = "nudtanggal";
            this.nudtanggal.Size = new System.Drawing.Size(46, 20);
            this.nudtanggal.TabIndex = 5;
            this.nudtanggal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dudbulan
            // 
            this.dudbulan.Items.Add("Januari");
            this.dudbulan.Items.Add("Februari");
            this.dudbulan.Items.Add("Maret");
            this.dudbulan.Items.Add("April");
            this.dudbulan.Items.Add("Mei");
            this.dudbulan.Items.Add("Juni");
            this.dudbulan.Items.Add("Juli");
            this.dudbulan.Items.Add("Agustus");
            this.dudbulan.Items.Add("September");
            this.dudbulan.Items.Add("Oktober");
            this.dudbulan.Items.Add("November");
            this.dudbulan.Items.Add("Desember");
            this.dudbulan.Location = new System.Drawing.Point(83, 25);
            this.dudbulan.Name = "dudbulan";
            this.dudbulan.Size = new System.Drawing.Size(120, 20);
            this.dudbulan.TabIndex = 1;
            this.dudbulan.Text = "Januari";
            this.dudbulan.SelectedItemChanged += new System.EventHandler(this.dudbulan_SelectedItemChanged);
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(284, 23);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 23);
            this.btntambah.TabIndex = 2;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(394, 22);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 3;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.monthCalendar1.Location = new System.Drawing.Point(18, 63);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 399);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.dudbulan);
            this.Controls.Add(this.nudtanggal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudtanggal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudtanggal;
        private System.Windows.Forms.DomainUpDown dudbulan;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

