using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsBasvurusu
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int ydSayisi = 0;
            string secilenDiller = "Seçilen Diller: ";

            if (checkBox1.Checked)
            {
                ydSayisi++;
                secilenDiller += checkBox1.Text + " ";
            }

            if (checkBox2.Checked)
            {
                ydSayisi++;
                secilenDiller += checkBox2.Text + " ";
            }

            if (checkBox3.Checked)
            {
                ydSayisi++;
                secilenDiller += checkBox3.Text + " ";
            }

            if (checkBox4.Checked)
            {
                ydSayisi++;
                secilenDiller += checkBox4.Text + " ";
            }

            lblSecilenDiller.Text = secilenDiller;

            if (ydSayisi>=2)
            {
                lblSonuc.Text = "İşe Uygun";
            }
            else
            {
                lblSonuc.Text = "İşe Uygun Değil";
            }

        }
    }
}
