using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayilarinToplami
{
    public partial class Form1 : Form
    {
        int toplam;
        int adet;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adet++;
            int sayi;
            sayi = int.Parse(textBox1.Text);
            toplam = toplam + sayi;
            label1.Text = "Toplam: " + toplam;
            label2.Text = "Girilen sayı: " + adet;

            if(toplam>=100)
            {
                button1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toplam = 0;
            adet = 0;
        }
    }
}
