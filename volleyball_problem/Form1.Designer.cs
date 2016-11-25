namespace volleyball_problem
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
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblhasil = new System.Windows.Forms.Label();
            this.BtnHitung = new System.Windows.Forms.Button();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.TxtHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(12, 82);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(39, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Skor B";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 39);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(39, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Skor A";
            // 
            // lblhasil
            // 
            this.lblhasil.AutoSize = true;
            this.lblhasil.Location = new System.Drawing.Point(12, 164);
            this.lblhasil.Name = "lblhasil";
            this.lblhasil.Size = new System.Drawing.Size(30, 13);
            this.lblhasil.TabIndex = 1;
            this.lblhasil.Text = "Hasil";
            // 
            // BtnHitung
            // 
            this.BtnHitung.Location = new System.Drawing.Point(15, 115);
            this.BtnHitung.Name = "BtnHitung";
            this.BtnHitung.Size = new System.Drawing.Size(153, 23);
            this.BtnHitung.TabIndex = 2;
            this.BtnHitung.Text = "Hitung";
            this.BtnHitung.UseVisualStyleBackColor = true;
            this.BtnHitung.Click += new System.EventHandler(this.BtnHitung_Click);
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(74, 32);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(94, 20);
            this.Txt1.TabIndex = 3;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(74, 75);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(94, 20);
            this.Txt2.TabIndex = 4;
            // 
            // TxtHasil
            // 
            this.TxtHasil.Location = new System.Drawing.Point(74, 161);
            this.TxtHasil.Name = "TxtHasil";
            this.TxtHasil.ReadOnly = true;
            this.TxtHasil.Size = new System.Drawing.Size(94, 20);
            this.TxtHasil.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 206);
            this.Controls.Add(this.TxtHasil);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.BtnHitung);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblhasil);
            this.Controls.Add(this.lblB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblhasil;
        private System.Windows.Forms.Button BtnHitung;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox TxtHasil;
    }
}

