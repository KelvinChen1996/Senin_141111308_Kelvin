namespace Latihan_3_1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton_Bold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Italic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripButton_Bold,
            this.toolStripButton_Italic,
            this.toolStripButton_Underline,
            this.toolStripComboBox2,
            this.toolStripComboBox3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(461, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripButton_Bold
            // 
            this.toolStripButton_Bold.CheckOnClick = true;
            this.toolStripButton_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Bold.Image = global::Latihan_3_1.Properties.Resources.B;
            this.toolStripButton_Bold.Name = "toolStripButton_Bold";
            this.toolStripButton_Bold.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Bold.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton_Italic
            // 
            this.toolStripButton_Italic.CheckOnClick = true;
            this.toolStripButton_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Italic.Image = global::Latihan_3_1.Properties.Resources.i;
            this.toolStripButton_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Italic.Name = "toolStripButton_Italic";
            this.toolStripButton_Italic.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Italic.Text = "I";
            this.toolStripButton_Italic.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton_Underline
            // 
            this.toolStripButton_Underline.CheckOnClick = true;
            this.toolStripButton_Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Underline.Image = global::Latihan_3_1.Properties.Resources.u;
            this.toolStripButton_Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Underline.Name = "toolStripButton_Underline";
            this.toolStripButton_Underline.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Underline.Text = "toolStripButton3";
            this.toolStripButton_Underline.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged_1);
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox3.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox3_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(425, 136);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(23, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 218);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Italic;
        private System.Windows.Forms.ToolStripButton toolStripButton_Underline;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBold;
        private System.Windows.Forms.ToolStripButton toolStripButton_Bold;
    }
}

