using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuOyunu
{
    public partial class Form1 : Form
    {
        int sayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(1, 4);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sayi==1)
            {
                pictureBox1.Image = Properties.Resources.yildiz;
                button1.Visible = true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.kurukafa;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (sayi == 2)
            {
                pictureBox2.Image = Properties.Resources.yildiz;
                button1.Visible = true;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.kurukafa;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (sayi == 3)
            {
                pictureBox3.Image = Properties.Resources.yildiz;
                button1.Visible = true;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.kurukafa;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(1, 4);
            pictureBox1.Image = Properties.Resources.kutu;
            pictureBox2.Image = Properties.Resources.kutu;
            pictureBox3.Image = Properties.Resources.kutu;
            button1.Visible = false;
        }
    }
}
