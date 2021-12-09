using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hiz1,hiz2,hiz3;
            Random rastgele = new Random();
            
            hiz1 = rastgele.Next(10, 80);
            hiz2 = rastgele.Next(10, 80);
            hiz3 = rastgele.Next(10, 80);

            pictureBox1.Left += hiz1;
            pictureBox2.Left += hiz2;
            pictureBox3.Left += hiz3;

            if (pictureBox1.Left + pictureBox1.Width > panel1.Left)
            {
                lblMesaj.Text = "Uçak 1 kazandı!";
                button1.Enabled = false;
                button2.Visible = true;
            }
            else if (pictureBox2.Left + pictureBox2.Width > panel1.Left)
            {
                lblMesaj.Text = "Uçak 2 kazandı!";
                button1.Enabled = false;
                button2.Visible = true;
            }
            else if (pictureBox3.Left + pictureBox3.Width > panel1.Left)
            {
                lblMesaj.Text = "Uçak 3 kazandı!";
                button1.Enabled = false;
                button2.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 52;
            pictureBox2.Left = 52;
            pictureBox3.Left = 52;
            lblMesaj.Text = "İlerle ye basınız...";
            button1.Enabled = true;
            button2.Visible = false;

        }
    }
}
