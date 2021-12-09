using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boyutlandirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Width = 100;
            label1.Height = 40;
            btnKucuk.Enabled = false;
            btnOrta.Enabled = true;
            btnBuyuk.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Width = 200;
            label1.Height = 70;
            btnKucuk.Enabled = true;
            btnOrta.Enabled = false;
            btnBuyuk.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Width = 400;
            label1.Height = 200;
            btnKucuk.Enabled = true;
            btnOrta.Enabled = true;
            btnBuyuk.Enabled = false;
        }

        private void BtnYukari_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 10;
        }

        private void BtnAsagi_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 10;
        }

        private void BtnSag_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 10;
        }

        private void BtnSol_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 10;
        }

        private void BtnSifirla_Click_1(object sender, EventArgs e)
        {
            label1.Left = 200;
            label1.Top = 150;
        }

        private void BtnSagUst_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 10;
            label1.Top = label1.Top - 10;
        }

        private void BtnSagAlt_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 10;
            label1.Top = label1.Top + 10;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            // this.Close();
            Application.Exit();
        }
    }
}
