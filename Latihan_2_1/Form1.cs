using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime tglLahir = new DateTime(1996,6,7);
            monthCalendar1.AddBoldedDate(tglLahir);
            dudbulan.SelectedIndex = 0;

            DateTime libur = new DateTime(2016, 1, 1);
            while (libur.Year == 2016)
            {
                if (libur.DayOfWeek == DayOfWeek.Saturday || libur.DayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalendar1.AddBoldedDate(libur);
                }
                libur = libur.AddDays(1);
            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            DateTime bolddate = new DateTime(2016, dudbulan.SelectedIndex + 1, Convert.ToInt16(nudtanggal.Value));
            monthCalendar1.AddAnnuallyBoldedDate(bolddate);
            monthCalendar1.UpdateBoldedDates();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            DateTime clearbold = monthCalendar1.SelectionRange.Start.Date;
            monthCalendar1.RemoveAnnuallyBoldedDate(clearbold);
            monthCalendar1.UpdateBoldedDates();
        }

        private void dudbulan_SelectedItemChanged(object sender, EventArgs e)
        {
            if (dudbulan.Text == "Januari" || dudbulan.Text == "Maret" || dudbulan.Text == "Mei" || dudbulan.Text == "Juli" || dudbulan.Text == "Agustus" || dudbulan.Text == "Oktober" || dudbulan.Text == "Desember")
                nudtanggal.Maximum = 31;
            else if (dudbulan.Text == "Februari")
                nudtanggal.Maximum = 29;
            else
                nudtanggal.Maximum = 30;
        }
    }
}
