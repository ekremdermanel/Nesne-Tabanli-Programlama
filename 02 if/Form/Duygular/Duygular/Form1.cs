using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duygular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Mutlu";
                pbResim.Image = Properties.Resources.mutlu;
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "Üzgün";
                pbResim.Image = Properties.Resources.uzgun;
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "Şaşkın";
                pbResim.Image = Properties.Resources.saskin;
            }
            else if (radioButton4.Checked)
            {
                label1.Text = "Üzgün";
                pbResim.Image = Properties.Resources.kizgin;
            }
            else
            {
                label1.Text = "Şaşkın";
                pbResim.Image = Properties.Resources.yorgun;
            }
        }
    }
}
