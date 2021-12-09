using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GectiKaldi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double puan1, puan2, ortalama;
            puan1 = double.Parse(textBox1.Text);
            puan2 = double.Parse(textBox2.Text);
            ortalama = (puan1 + puan2) / 2;
            label3.Text = "Ortalama: " + ortalama;
            if (ortalama>=50)
            {
                label4.Text = "Geçti";
                label4.ForeColor = Color.Green;
                pbResim.Image = Properties.Resources.yes;
            }
            else
            {
                label4.Text = "Kaldı";
                label4.ForeColor = Color.Red;
                pbResim.Image = Properties.Resources.no;
            }
        }
    }
}
