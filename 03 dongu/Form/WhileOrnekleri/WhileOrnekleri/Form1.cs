using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileOrnekleri
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

            int i;
            i = 1;
            while (i<=10)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int i;
            i = 10;
            while (i >= 1)
            {
                listBox1.Items.Add(i);
                i--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rastgele = new Random();

            int i,sayi;
            i = 1;
            while (i <= 10)
            {
                sayi = rastgele.Next(100);
                listBox1.Items.Add(sayi);
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i;
            i = 1;
            do
            {
                listBox1.Items.Add(i);
                i++;
            } while (i<=10);
        }
    }
}
