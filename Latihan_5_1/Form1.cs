using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Latihan_4_1
{
    public partial class Form1 : Form
    {
        public bool isSave = true;
        public string direktoriSave = "";
        public Form1()
        {
            InitializeComponent();
        }

        public void refresh_teks()
        {
            
            bool isBold, isItalic, isUnderline;
            int panjang = richTextBox1.SelectionLength;
            int mulai = richTextBox1.SelectionStart;
            float fontSize;
            string fontFamily;
           
            this.richTextBox1.SelectionChanged -= new System.EventHandler(this.richTextBox1_SelectionChanged);
            if (panjang == 0)
            {
                fontFamily = (toolStripComboBox2.Text == "") ? richTextBox1.SelectionFont.FontFamily.Name : toolStripComboBox2.Text;
                fontSize = (toolStripComboBox1.Text == "") ? richTextBox1.SelectionFont.Size : Convert.ToSingle(toolStripComboBox1.Text);
                FontStyle style = (toolStripButton_Bold.Checked) ? FontStyle.Bold : FontStyle.Regular;
                style |= (toolStripButton_Italic.Checked) ? FontStyle.Italic : FontStyle.Regular;
                style |= (toolStripButton_Underline.Checked) ? FontStyle.Underline : FontStyle.Regular;
                Font font_baru = new Font(fontFamily, fontSize, style);
                richTextBox1.SelectionFont = font_baru;
            }
            for (int i = mulai; i < mulai + panjang; i++)
            {
                richTextBox1.SelectionChanged -= new System.EventHandler(this.richTextBox1_SelectionChanged);
                richTextBox1.Select(i, 1);
                fontFamily = (toolStripComboBox2.Text == "") ? richTextBox1.SelectionFont.FontFamily.Name : toolStripComboBox2.Text;
                fontSize = (toolStripComboBox1.Text == "") ? richTextBox1.SelectionFont.Size : Convert.ToSingle(toolStripComboBox1.Text);

                isBold = richTextBox1.SelectionFont.Bold;
                isItalic = richTextBox1.SelectionFont.Italic;
                isUnderline = richTextBox1.SelectionFont.Underline;

                FontStyle style = (toolStripButton_Bold.Checked) ? FontStyle.Bold : FontStyle.Regular;
                style |= (toolStripButton_Italic.Checked) ? FontStyle.Italic : FontStyle.Regular;
                style |= (toolStripButton_Underline.Checked) ? FontStyle.Underline : FontStyle.Regular;
                Font font_baru = new Font(fontFamily, fontSize, style);
                richTextBox1.SelectionFont = font_baru;
            }

            richTextBox1.Select(mulai, panjang);
            richTextBox1.Focus();

            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
        }

        private void save()
        {
            DialogResult dialog_result;
            if (direktoriSave == "")
            {
                saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf";
                dialog_result = saveFileDialog1.ShowDialog();
                if (dialog_result == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    direktoriSave = saveFileDialog1.FileName;
                }
            }
            else
            {
                richTextBox1.SaveFile(direktoriSave);
            }
            isSave = true;
        }

        private void exit()
        {
            if (!isSave)
            {
                DialogResult dialog_result;
                dialog_result = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNo);
                if (dialog_result == DialogResult.No)
                {
                    Application.ExitThread();
                }
                else if (dialog_result == DialogResult.Yes)
                {
                    save();
                    Application.ExitThread();
                }
            }
            else
                Application.ExitThread();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                save();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        public string getBackgroundColor()
        {
            return richTextBox1.BackColor.Name;
        }

        public void setBackgroundColor(string color)
        {
            richTextBox1.BackColor = Color.FromName(color);
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection kumpulanfont = new InstalledFontCollection();

            // menempatkan nama2 font family pada combobox2
            foreach (FontFamily i in kumpulanfont.Families)
            {
                toolStripComboBox2.Items.Add(i.Name);
            }
            toolStripComboBox2.SelectedIndex = 9; // Arial default


            //menciptakan ukuran font mulai dari 5 hingga 72 pada combobox 1
            for (int i = 5; i <= 72; i++)
                toolStripComboBox1.Items.Add(i);
            toolStripComboBox1.SelectedIndex = 7;  // 12

            toolStripComboBox2.ComboBox.LostFocus += new EventHandler(toolStripComboBox2_LostFocus);
            toolStripComboBox1.ComboBox.LostFocus += new EventHandler(toolStripComboBox2_LostFocus);
            toolStripComboBox2.ComboBox.DrawItem += new DrawItemEventHandler(toolStripComboBox2_DrawItem);
            toolStripComboBox2.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;


            //mengambil semua properties warna dan disimpan ke combobox 3
            foreach (PropertyInfo property in typeof(Color).GetProperties())
            {
                if (property.PropertyType == typeof(Color))
                {
                    toolStripComboBox3.Items.Add(property.Name);
                    toolStripComboBox4.Items.Add(property.Name);
                }
            }

            toolStripComboBox3.SelectedIndex = 8;// Black default
            toolStripComboBox3.ComboBox.LostFocus += new EventHandler(toolStripComboBox2_LostFocus);
            toolStripComboBox3.ComboBox.DrawItem += new DrawItemEventHandler(toolStripComboBox3_DrawItem);
            toolStripComboBox3.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            toolStripComboBox4.Text = "White";
            richTextBox1.SelectionBackColor = Color.FromName(toolStripComboBox4.Text);
            toolStripComboBox4.ComboBox.LostFocus += new EventHandler(toolStripComboBox4_LostFocus);
            toolStripComboBox4.ComboBox.DrawItem += new DrawItemEventHandler(toolStripComboBox3_DrawItem);
            toolStripComboBox4.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;


            refresh_teks();
        }

        private void toolStripComboBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            //menampilkan font style agar kelihatan
            e.DrawBackground();
            e.Graphics.DrawString(toolStripComboBox2.Items[e.Index].ToString(), new Font(toolStripComboBox2.Items[e.Index].ToString(), toolStripComboBox2.Font.Size), Brushes.Black, e.Bounds);

        }
        private void toolStripComboBox3_DrawItem(object sender, DrawItemEventArgs e)
        {
            // mengatasi agar dropdownlist kelihatan 

            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.toolStripComboBox3.Items[e.Index].ToString();
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

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox TSC = (ToolStripComboBox)sender;
            if (!TSC.Focused)
                return;
            refresh_teks();
        }

        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int panjang = richTextBox1.SelectionLength;
            int mulai = richTextBox1.SelectionStart;
            ToolStripComboBox TSC = (ToolStripComboBox)sender;
            if (!TSC.Focused)
                return;
            richTextBox1.SelectionColor = Color.FromName(toolStripComboBox3.Text);
            richTextBox1.Focus();
            richTextBox1.Select(mulai, panjang);

            
            refresh_teks();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox TSC = (ToolStripComboBox)sender;
            if (!TSC.Focused)
                return;
            refresh_teks();
        }

        private void toolStripButton_Italic_Click(object sender, EventArgs e)
        {
            refresh_teks();
        }

        private void toolStripButton_Underline_Click(object sender, EventArgs e)
        {
            refresh_teks();
        }

        private void toolStripButton_Bold_Click(object sender, EventArgs e)
        {
            refresh_teks();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                try
                {
                    toolStripComboBox1.SelectedIndex = (int)richTextBox1.SelectionFont.Size - 5;
                }
                catch
                {
                    toolStripComboBox1.Text = "";
                }

                try
                {
                    toolStripComboBox2.SelectedItem = richTextBox1.SelectionFont.FontFamily.Name;
                }
                catch
                {
                    toolStripComboBox2.Text = "";
                }

                try
                {
                    toolStripComboBox3.SelectedItem = richTextBox1.SelectionColor.Name;
                }
                catch
                {
                    toolStripComboBox3.Text = "";
                }

                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Bold") != -1)
                    toolStripButton_Bold.Checked = true;

                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Italic") != -1)
                    toolStripButton_Italic.Checked = true;

                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Underline") != -1)
                    toolStripButton_Underline.Checked = true;
            }
            else
            {
                toolStripComboBox1.SelectedIndex = 7;
                toolStripComboBox2.SelectedIndex = 9;
            }

            if (richTextBox1.SelectionColor.Name == "0")
            {
                toolStripComboBox3.Text = "Black";
            }
            else
            {
                toolStripComboBox3.Text = richTextBox1.SelectionColor.Name;
            }
            toolStripComboBox4.Text = richTextBox1.BackColor.Name;
        }

        private void toolStripComboBox2_LostFocus(object sender, EventArgs e)
        {
            refresh_teks();
        }

        private void toolStripComboBox3_LostFocus(object sender, EventArgs e)
        {
            int panjang = richTextBox1.SelectionLength;
            int mulai = richTextBox1.SelectionStart;
            richTextBox1.SelectionColor = Color.FromName(toolStripComboBox3.Text);
            richTextBox1.Select(mulai, panjang);
        }

        private void toolStripComboBox4_LostFocus(object sender, EventArgs e)
        {
            int panjang = richTextBox1.SelectionLength;
            int mulai = richTextBox1.SelectionStart;
            richTextBox1.SelectionBackColor = Color.FromName(toolStripComboBox4.Text);
            richTextBox1.Select(mulai, panjang);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog_result;
                if (!isSave)
                {
                    dialog_result = MessageBox.Show("Apakah Anda ingin menyimpan file ini?", "Save file", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
                    if (dialog_result == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (dialog_result == DialogResult.Yes)
                    {
                        save();
                    }
                }

                richTextBox1.Clear();
                direktoriSave = "";
                isSave = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog_result;
                if (!isSave)
                {
                    dialog_result = MessageBox.Show("Apakah Anda ingin menyimpan file ini?", "Save file", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    
                    if (dialog_result == DialogResult.Yes)
                    {
                        save();
                    }
                }
                dialog_result = openFileDialog1.ShowDialog();
                if (dialog_result == DialogResult.OK)
                {
                    direktoriSave = openFileDialog1.FileName;
                    isSave = true;
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isSave = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog_result = MessageBox.Show("Apakah Anda ingin keluar?", "Keluar file", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialog_result==DialogResult.Yes)
                exit();

        }

        Editor formEditor;
        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formEditor == null || !formEditor.IsHandleCreated)
            {
                formEditor = new Editor();
                formEditor.MdiParent = this;
                formEditor.BringToFront();
                richTextBox1.SendToBack();
                formEditor.Show();
            }
            else
            {
                formEditor.Show();
            }
        }

        public void showRichTextBox()
        {
            richTextBox1.BringToFront();
            richTextBox1.Focus();
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (richTextBox1.SelectionLength == 0)
                {
                    contextMenuStrip1.Items[0].Enabled = false;
                    contextMenuStrip1.Items[1].Enabled = false;
                    contextMenuStrip1.Items[3].Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items[0].Enabled = true;
                    contextMenuStrip1.Items[1].Enabled = true;
                    contextMenuStrip1.Items[3].Enabled = true;
                }
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void CopytoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void CuttoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void PastetoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                richTextBox1.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
        }

        private void DeletetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0)
            {
                return;
            }

            richTextBox1.SelectedText = "";
        }

       

        private void toolStripComboBox1_DropDownStyleChanged(object sender, EventArgs e)
        {
            //refresh_teks();
        }

        private void toolStripComboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int panjang = richTextBox1.SelectionLength;
            int mulai = richTextBox1.SelectionStart;
            ToolStripComboBox x = (ToolStripComboBox)sender;
            if (!x.Focused)
                return;
            richTextBox1.SelectionBackColor = Color.FromName(toolStripComboBox4.Text);
            richTextBox1.Focus();
            richTextBox1.Select(mulai, panjang);
            refresh_teks();
        }
    }
}
