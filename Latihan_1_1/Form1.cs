using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private static string GabungString(string a, string b)
        {
            return a + b;
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = label6.Text = label7.Text = label8.Text = "0";
            label2.Text = label4.Text = "00";
            label9.Text = label10.Text = "0";
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = "";
            
            label5.Text = vScrollBar1.Value.ToString();
            label2.Text = GabungString(label5.Text, label6.Text);
            DateTime mindate = new DateTime((DateTime.Today.Year - Convert.ToInt16(label2.Text)), DateTime.Today.Month, DateTime.Today.Day);
            dateTimePicker1.MinDate = mindate;
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = "";
            label6.Text = vScrollBar2.Value.ToString();
            label2.Text = GabungString(label5.Text, label6.Text);
            DateTime mindate = new DateTime((DateTime.Today.Year - Convert.ToInt16(label2.Text)), DateTime.Today.Month, DateTime.Today.Day);
            dateTimePicker1.MinDate = mindate;
        }

        private void vScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = "";
            label7.Text = vScrollBar4.Value.ToString();
            label4.Text = GabungString(label7.Text, label8.Text);
            DateTime maxdate = new DateTime((DateTime.Today.Year + Convert.ToInt16(label4.Text)), DateTime.Today.Month, DateTime.Today.Day);
            dateTimePicker1.MaxDate = maxdate;
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = "";
            label8.Text = vScrollBar3.Value.ToString();
            label4.Text = GabungString(label7.Text, label8.Text);
            DateTime maxdate = new DateTime((DateTime.Today.Year + Convert.ToInt16(label4.Text)), DateTime.Today.Month, DateTime.Today.Day);
            dateTimePicker1.MaxDate = maxdate;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label9.Text = hScrollBar1.Value.ToString();
            txtrange.Text = GabungString(label9.Text, label10.Text);
            DateTime mindate = new DateTime(DateTime.Today.Year - Convert.ToInt16(txtrange.Text), DateTime.Today.Month, DateTime.Today.Day);
            DateTime maxdate = new DateTime(DateTime.Today.Year + Convert.ToInt16(txtrange.Text), DateTime.Today.Month, DateTime.Today.Day);
            txtmindate.Text = mindate.ToShortDateString();
            txtmaxdate.Text = maxdate.ToShortDateString();
            dateTimePicker2.MinDate = mindate;
            dateTimePicker2.MaxDate = maxdate;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label10.Text = hScrollBar2.Value.ToString();
            txtrange.Text = GabungString(label9.Text, label10.Text);
            DateTime mindate = new DateTime(DateTime.Today.Year - Convert.ToInt16(txtrange.Text), DateTime.Today.Month, DateTime.Today.Day);
            DateTime maxdate = new DateTime(DateTime.Today.Year + Convert.ToInt16(txtrange.Text), DateTime.Today.Month, DateTime.Today.Day);
            txtmindate.Text = mindate.ToShortDateString();
            txtmaxdate.Text = maxdate.ToShortDateString();
            dateTimePicker2.MinDate = mindate;
            dateTimePicker2.MaxDate = maxdate;
        }

        
    }
}
