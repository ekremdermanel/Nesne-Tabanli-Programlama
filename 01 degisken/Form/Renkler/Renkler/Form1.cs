using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renkler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void Label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "Sarı Seçildi";
            this.BackColor = Color.Yellow;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "Kırmızı Seçildi";
            this.BackColor = Color.Red;
        }
    }
}
