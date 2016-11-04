using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace Latihan_4_1
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Form1 frm = (Form1)MdiParent;
            frm.setBackgroundColor(cb_bgcolor.Text);
            frm.showRichTextBox();
            this.Close();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            Form1 frm = (Form1)MdiParent;
            Color color = new Color();
            PropertyInfo[] colors = color.GetType().GetProperties();
            foreach (PropertyInfo PIcolor in colors)
            {
                if (PIcolor.PropertyType == typeof(System.Drawing.Color))
                {
                    cb_bgcolor.Items.Add(PIcolor.Name);
                }
            }
            this.cb_bgcolor.DrawMode = DrawMode.OwnerDrawFixed;
            this.cb_bgcolor.DrawItem += new DrawItemEventHandler(cb_bgcolor_DrawItem);
            this.cb_bgcolor.Text = frm.getBackgroundColor();
        }

        private void cb_bgcolor_DrawItem(object sender, DrawItemEventArgs e)
        {
            // mengatasi agar dropdownlist kelihatan 

            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);
                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.cb_bgcolor.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                //Menggambar persegi panjang dan mengisinya dengan warna saat ini
                //dan menambahkan nama di sebelah kanan warna
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Background Color")
            {
                panel1.Visible = true;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form1 frm = (Form1)MdiParent;
            frm.showRichTextBox();
            this.Close();
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = (Form1)MdiParent;
            frm.showRichTextBox();
        }
    }
}
