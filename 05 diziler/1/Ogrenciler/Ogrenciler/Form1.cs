using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenciler
{
    public partial class Form1 : Form
    {

        string[] isimler = { "Berkay", "Tuana Rukiye", "Ali Cihan", "Muhammed Mehdi", "Sultan Hilal", "Yusuf", "Ali", "Abdullah", "Mertcan", "Zühre", "Beyzanur", "Enes", "Ensar", "Dilara", "Ege" };
        int[] numaralar = { 1008, 1014, 1015, 1017, 1031, 1044, 1045, 1060, 1074, 1081, 1090, 1099, 1103, 1106, 1134 };
        bool[] cinsiyetler = { true, false, true, true, false, true, true, true, true, false, false, true, true, false, true };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in isimler)
            {
                listBox1.Items.Add(item);
            }

            RastgeleSec();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilen = listBox1.SelectedIndex;
            label1.Text = numaralar[secilen].ToString();
            label2.Text = isimler[secilen];
            pictureBox1.Image = cinsiyetler[secilen] ? Properties.Resources.erkek : Properties.Resources.kiz;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RastgeleSec();
        }

        void RastgeleSec()
        {
            Random rastgele = new Random();
            int secilen = rastgele.Next(isimler.Length);
            listBox1.SelectedIndex = secilen;
        }
    }
}
