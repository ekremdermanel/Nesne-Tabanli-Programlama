using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class Form1 : Form
    {
        int tutarMarka;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            comboBox1.SelectedIndex = 0;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = true;
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            dateTimePicker2.Value = dateTimePicker1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ozet;

            ozet = "Marka: " + comboBox1.SelectedItem.ToString();
            ozet += "\nVites: ";

            int tutarVites;
            if (radioButton1.Checked)
            {
                ozet += "Manuel";
                tutarVites = 0;
            }
            else
            {
                ozet += "Otomatik";
                tutarVites = 20;
            }

            DateTime alisTarihi = dateTimePicker1.Value;
            DateTime iadeTarihi = dateTimePicker2.Value;
            int gun = (iadeTarihi - alisTarihi).Days;
            gun++;
            ozet += "\nGün Sayısı: " + gun;

            lblOzet.Text = ozet;

            int tutarToplam;
            tutarToplam = (tutarMarka + tutarVites) * gun;
            lblTutar.Text = "Toplam Tutar: " + tutarToplam + " TL";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                pictureBox1.Image = Properties.Resources.renault;
                tutarMarka = 200;
            }
            else if (comboBox1.SelectedIndex==1)
            {
                pictureBox1.Image = Properties.Resources.honda;
                tutarMarka = 300;
            }
            else if(comboBox1.SelectedIndex==2)
            {
                pictureBox1.Image = Properties.Resources.bmw;
                tutarMarka = 500;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.range;
                tutarMarka = 1000;
            }
        }
    }
}
