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
            DateTime dogumTarihi;
            dogumTarihi = dateTimePicker1.Value;

            DateTime bugun;
            bugun = DateTime.Today;

            int yas;
            yas = bugun.Year - dogumTarihi.Year;

            lblYas.Text = "Yaşınız: " + yas;


            if (yas>=18 && yas<=30)
            {
                lblSonuc.Text = "İşe Uygun";
            }
            else
            {
                lblSonuc.Text = "İşe Uygun Değil";
            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-30);
        }
    }
}
