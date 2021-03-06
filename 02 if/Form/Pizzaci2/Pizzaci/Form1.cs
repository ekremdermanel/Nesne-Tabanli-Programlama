using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            pbPizzaSecim.Image = Properties.Resources.evet;
            lblPizza.Text = comboBox1.SelectedItem.ToString();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            pbKenarSecim.Image = Properties.Resources.evet;
            lblKenar.Text = radioButton1.Text;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            pbKenarSecim.Image = Properties.Resources.evet;
            lblKenar.Text = radioButton2.Text;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            pbKenarSecim.Image = Properties.Resources.evet;
            lblKenar.Text = radioButton3.Text;
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double tutarPizza = 0, tutarKenar = 0, tutarSos = 0, tutarToplam = 0;

            if (comboBox1.SelectedIndex==0)
            {
                tutarPizza = 50;
            }
            else if (comboBox1.SelectedIndex==1)
            {
                tutarPizza = 60;
            }
            else
            {
                tutarPizza = 80;
            }

            if (radioButton3.Checked)
            {
                tutarKenar = 10;
            }

            if(checkBox1.Checked)
            {
                tutarSos += 3;
            }

            if (checkBox2.Checked)
            {
                tutarSos += 3;
            }

            if (checkBox3.Checked)
            {
                tutarSos += 3;
            }

            if (checkBox4.Checked)
            {
                tutarSos += 3;
            }

            tutarToplam = tutarPizza + tutarKenar + tutarSos;
            lblToplam.Text = "Toplam Tutar: " + tutarToplam + " TL";

            pbToplam.Visible = true;
            lblToplam.Visible = true;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            pbKetcap.Visible = checkBox1.Checked;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            pbMayonez.Visible = checkBox2.Checked;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            pbHardal.Visible = checkBox3.Checked;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            pbAciSos.Visible = checkBox4.Checked;
        }
    }
}
