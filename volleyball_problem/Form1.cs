using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        long modulus = 1000000007;
        public Form1()
        {
            InitializeComponent();
        }

        private long Faktorial(long n)
        {
            long hasil = 1;
            for (int i = 1; i <= n; i++)
            {
                hasil *= i;
                hasil %= modulus;
            }
            return hasil;
        }

        private long InverseModulus(long x)
        {
            return Pangkat(x, modulus - 2);
        }

        private long Kombinasi(long x, long y)
        {
            long hasil = 1;
            if (x < y)
            {
                return 0;
            } 
            
            hasil = ((((Faktorial(x) % modulus) * InverseModulus(Faktorial(x - y))) % modulus) * InverseModulus(Faktorial(y))) % modulus;
            return hasil;
        }

        private long Pangkat(long x, long y)
        {
            long hasil = 1;
            while (y > 0)
            {
                if (y % 2 == 1)
                    hasil = (hasil * x) % modulus;
                x = (x * x) % modulus;
                y /= 2;
            }
            return hasil % modulus;
        }

        private static void swap(ref long Skor_A, ref long Skor_B)
        {
            if (Skor_A < Skor_B)
            {
                long tampung = Skor_A;
                Skor_A = Skor_B;
                Skor_B = tampung;
            }

        }
        private void BtnHitung_Click(object sender, EventArgs e)
        {
           
            long skor_a, skor_b, hasil;
            skor_a = Convert.ToInt64(Txt1.Text);
            skor_b = Convert.ToInt64(Txt2.Text);

            swap(ref skor_a, ref skor_b);

            if ((skor_a < 25) || (skor_a > 25 && (skor_a - skor_b != 2)) || (skor_a - skor_b < 2))
            {
                hasil = 0;
            }
            else
            {
                hasil = ((Kombinasi(Math.Min(skor_a + skor_b - 1, 47), Math.Min(skor_a - 1, 24))) * Pangkat(2, skor_a - 25)) % modulus;

            }
            TxtHasil.Text = hasil.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txt1.Focus();
            Txt1.TabIndex = 1;
        }
    }
}
