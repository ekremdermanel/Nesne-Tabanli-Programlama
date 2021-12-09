using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreUretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi;
            string sifre = "";

            for (int i = 0; i < 3; i++)
            {
                sayi = rastgele.Next(10);
                sifre = sifre + sayi;
            }

            for (int i = 0; i < 3; i++)
            {
                sayi = rastgele.Next(65,91);
                sifre = sifre + Convert.ToChar(sayi);
            }

            for (int i = 0; i < 4; i++)
            {
                sayi = rastgele.Next(33, 48);
                sifre = sifre + Convert.ToChar(sayi);
            }

            label1.Text = sifre;
        }
    }
}
