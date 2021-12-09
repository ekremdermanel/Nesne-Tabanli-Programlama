using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[6];
            Random rastgele = new Random();
            int sayi, sayac = 0;

            while (sayac < 6)
            {
                sayi = rastgele.Next(1, 50);
                if (Array.IndexOf(sayilar,sayi)==-1)
                {
                    sayilar[sayac] = sayi;
                    sayac++;
                }
            }

            Array.Sort(sayilar);

            listBox1.Items.Clear();
            for (int i = 0; i < sayilar.Length; i++)
            {
                listBox1.Items.Add(sayilar[i]);
            }
            

        }
    }
}
