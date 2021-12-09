using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            Random rastgele = new Random();
            sayi = rastgele.Next(10); // 0-9
            label1.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            Random rastgele = new Random();
            sayi = rastgele.Next(10,100); // 10-99
            listBox1.Items.Add(sayi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi;
            Random rastgele = new Random();

            for (int i = 0; i < 10; i++)
            {
                sayi = rastgele.Next(10, 100);
                listBox1.Items.Add(sayi);
            }

        }
    }
}
