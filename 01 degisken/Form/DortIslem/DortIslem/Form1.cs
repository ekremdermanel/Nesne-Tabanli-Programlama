using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DortIslem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = double.Parse(textBox1.Text);
            sayi2 = double.Parse(textBox2.Text);
            sonuc = sayi1 + sayi2;
            label3.Text = "Toplam: " + sonuc;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = double.Parse(textBox1.Text);
            sayi2 = double.Parse(textBox2.Text);
            sonuc = sayi1 - sayi2;
            label3.Text = "Fark: " + sonuc;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = double.Parse(textBox1.Text);
            sayi2 = double.Parse(textBox2.Text);
            sonuc = sayi1 * sayi2;
            label3.Text = "Çarpım: " + sonuc;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = double.Parse(textBox1.Text);
            sayi2 = double.Parse(textBox2.Text);
            sonuc = sayi1 / sayi2;
            label3.Text = "Bölüm: " + sonuc;
        }
    }
}
