using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsimListesi
{
    public partial class Form1 : Form
    {
        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int sira = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isimler[sira] = textBox1.Text;
            notlar[sira] = int.Parse(textBox2.Text);
            sira++;
            label2.Text = sira + " öğrenci girildi";
            if (sira==5)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < isimler.Length; i++)
            {
                listBox1.Items.Add(isimler[i] + " " + notlar[i]);
            }
        }
    }
}
