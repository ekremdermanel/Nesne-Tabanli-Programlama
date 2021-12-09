using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);
            toplam = sayi1 + sayi2;
            lblToplam.Text = "Sayıların toplamı: " + toplam;

        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
