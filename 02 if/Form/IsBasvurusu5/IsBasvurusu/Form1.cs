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

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-50);
            comboBox1.SelectedIndex = 0;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime dogumTarihi = dateTimePicker1.Value;
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumTarihi.Year;

            if (yas>=18 && yas<=25)
            {
                pictureBox1.Image = Properties.Resources.evet;
                label1.Text = "Yaş: " + yas;
                groupBox2.Visible = true;
                groupBox1.Enabled = false;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.hayir;
                label1.Text = "Yaş 18-25 arası olmalı";
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string ogrenim = comboBox1.SelectedItem.ToString();

            if (ogrenim=="Lise" || ogrenim=="Üniversite")
            {
                pictureBox2.Image = Properties.Resources.evet;
                label2.Text = "Öğrenim Durumu: " + ogrenim;
                groupBox3.Visible = true;
                groupBox2.Enabled = false;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.hayir;
                label2.Text = "Lise veya Üniversite olmalı";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Enabled = true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox3.Image = Properties.Resources.evet;
                label3.Text = "Erkek";
                groupBox4.Visible = true;
                groupBox3.Enabled = false;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.hayir;
                label3.Text = "Erkek olmalı";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox3.Enabled = true;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int ydSayisi = 0;
            string diller = "";

            if (checkBox1.Checked)
            {
                ydSayisi++;
                diller += checkBox1.Text + " ";
            }
            if (checkBox2.Checked)
            {
                ydSayisi++;
                diller += checkBox2.Text + " ";
            }
            if (checkBox3.Checked)
            {
                ydSayisi++;
                diller += checkBox3.Text + " ";
            }
            if (checkBox4.Checked)
            {
                ydSayisi++;
                diller += checkBox4.Text + " ";
            }

            if (ydSayisi>=2)
            {
                pictureBox4.Image = Properties.Resources.evet;
                label4.Text = diller;
                groupBox5.Visible = true;
                groupBox4.Enabled = false;
            }
            else
            {
                pictureBox4.Image = Properties.Resources.hayir;
                label4.Text = "En az 2 dil olmalı";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox4.Enabled = true;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;

            dateTimePicker1.Value = DateTime.Today;
            label1.Text = "Yaş";

            comboBox1.SelectedIndex = 0;
            label2.Text = "Öğrenim Durumu";

            radioButton1.Checked = true;
            label3.Text = "Cinsiyet";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            label4.Text = "Yabancı Dil";
        }
    }
}
