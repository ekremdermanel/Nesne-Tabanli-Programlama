using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleSayiDizisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[10];
            Random rastgele = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rastgele.Next(1, 51);
            }

            listBox1.Items.Clear();
            foreach (var item in sayilar)
            {
                listBox1.Items.Add(item);
            }


            int cift = 0, tek = 0;
            foreach (var item in sayilar)
            {
                if (item % 2 == 0)
                {
                    cift++;
                }
                else
                {
                    tek++;
                }
            }
            label1.Text = "Çiftlerin sayısı: " + cift;
            label2.Text = "Teklerin sayısı: " + tek;


            int eb = sayilar[0];
            int ek = sayilar[0];

            foreach (var item in sayilar)
            {
                if (item > eb)
                {
                    eb = item;
                }

                if (item < ek)
                {
                    ek = item;
                }
            }

            label3.Text = "En büyük sayı: " + eb;
            label4.Text = "En küçük sayı: " + ek;
        }
    }
}
