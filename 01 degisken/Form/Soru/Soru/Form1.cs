using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Doğru Cevap!";
        }

        private void Button2_MouseHover(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = true;
        }

        private void Button3_MouseHover(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = false;
        }
    }
}
