using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahmin
{
    public partial class Form1 : Form
    {
        int sayi, tahmin;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(1, 51);
            tahmin = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(1, 51);
            tahmin = 0;
            lblMesaj.Text = "Sayı Gir...";
            textBox1.Text = "";
            button2.Visible = false;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tahmin++;
            int girilenSayi = int.Parse(textBox1.Text);

            if (girilenSayi > sayi)
            {
                lblMesaj.Text = "Daha küçük sayı gir...";
            }
            else if (girilenSayi < sayi)
            {
                lblMesaj.Text = "Daha büyük sayı gir...";
            }
            else
            {
                lblMesaj.Text = "Tebrikler, " + tahmin + " tahminde bildiniz!";
                button1.Enabled = false;
                button2.Visible = true;
            }
        }
    }
}
