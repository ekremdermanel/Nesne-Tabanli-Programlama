using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekCiftListeleme
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

            sayi = rastgele.Next(1, 50);
            listBox1.Items.Add(sayi);

            if (sayi % 2 == 1)
            {
                listBox2.Items.Add(sayi);
            }
            else
            {
                listBox3.Items.Add(sayi);
            }

            label1.Text = listBox1.Items.Count.ToString();
            label2.Text = listBox2.Items.Count.ToString();
            label3.Text = listBox3.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                toplam = toplam + int.Parse(listBox1.Items[i].ToString());
            }
            label4.Text = toplam.ToString();
        }
    }
}
