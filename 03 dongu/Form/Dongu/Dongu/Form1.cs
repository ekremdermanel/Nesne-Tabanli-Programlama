using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dongu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add("merhaba");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 11; i <= 99; i+=2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 7; i <= 100; i += 7)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 10; i >= 1; i--)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 98; i >= 10; i-=2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 || i % 7 == 0)
                {
                    listBox1.Items.Add(i);
                } 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int secilen = int.Parse(comboBox1.SelectedItem.ToString());

            for (int i = 1; i <= secilen; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int sayi1 = Convert.ToInt32(numericUpDown1.Value);
            int sayi2 = Convert.ToInt32(numericUpDown2.Value);

            if(sayi1<sayi2)
            {
                for (int i = sayi1; i <= sayi2; i++)
                {
                    listBox1.Items.Add(i);
                }
            }
            else
            {
                for (int i = sayi1; i >= sayi2; i--)
                {
                    listBox1.Items.Add(i);
                }
            }
            

        }
    }
}
