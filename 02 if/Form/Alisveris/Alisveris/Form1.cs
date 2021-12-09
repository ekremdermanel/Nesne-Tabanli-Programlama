using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alisveris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double tutar = 0;

            if (checkBox1.Checked)
            {
                tutar = tutar + 3;
            }

            if (checkBox2.Checked)
            {
                tutar = tutar + 2;
            }

            if (checkBox3.Checked)
            {
                tutar = tutar + 5;
            }

            if (checkBox4.Checked)
            {
                tutar = tutar + 4;
            }

            if (checkBox5.Checked)
            {
                tutar = tutar + 5;
            }

            label1.Text = "Tutar: " + tutar + " TL";
        }
    }
}
