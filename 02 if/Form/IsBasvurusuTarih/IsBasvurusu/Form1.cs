using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsBasvurusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ogrenim = comboBox1.SelectedItem.ToString();

            if (ogrenim == "Üniversite" || ogrenim == "Lise")
            {
                lblSonuc.Text = "İşe Uygun";
            }
            else
            {
                lblSonuc.Text = "İşe Uygun Değil";
            }


        }
    }
}
