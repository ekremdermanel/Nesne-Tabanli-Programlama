using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VucutKitleEndeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo = double.Parse(textBox1.Text);

            double boyCm = double.Parse(textBox2.Text);
            double boy = boyCm / 100;

            double vke = kilo / (boy * boy);
            label3.Text = "Vücut Kitle Endeksi: " + vke;

            // Dünya Sağlık Örgütü referans aralığına göre
            // 18,5-24.99 arası değerler “normal” sayılır.
            // Vücut kitle endeksi değeri 25’in üzeri fazla kilolu
            // 30'un üzeri obezite, 40'ın üzeri morbid obezite olarak kabul edilir.

            if (vke < 18.5)
            {
                label4.Text = "Zayıf";
            }
            else if (vke < 25)
            {
                label4.Text = "Normal";
            }
            else if (vke < 30)
            {
                label4.Text = "Fazla Kilolu";
            }
            else if (vke < 40)
            {
                label4.Text = "Obez";
            }
            else
            {
                label4.Text = "Morbid Obez";
            }

        }
    }
}
