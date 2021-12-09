using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                return;
            }

            char karakter;

            if (radioButton1.Checked)
            {
                karakter = 'E';
            }
            else
            {
                karakter = 'K';
            }

            string metin;
            metin = karakter + " - " + textBox1.Text;

            listBox1.Items.Add(metin);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secilen = listBox1.SelectedIndex;
            if (secilen > -1)
            {
                listBox1.Items.RemoveAt(secilen);
            } 

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilen = listBox1.SelectedIndex;
            if (secilen > -1)
            {
                string satir = listBox1.SelectedItem.ToString();
                
                string cinsiyet;
                cinsiyet = satir.Substring(0, 1); // 0. karakterden başla 1 karakter al (E,K)

                if (cinsiyet=="E")
                {
                    pictureBox1.Image = Properties.Resources.erkek;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.kiz;
                }

                string isim;
                isim = satir.Substring(4); // 4. karakterden itibaren tümünü al
                lblOgrenci.Text = isim;
            }
            else
            {
                lblOgrenci.Text = "Öğrenci Seçiniz";
            }
        }
    }
}
