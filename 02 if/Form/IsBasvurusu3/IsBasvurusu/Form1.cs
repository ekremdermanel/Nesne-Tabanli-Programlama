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

        int yas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-50);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime tarih;
            tarih = dateTimePicker1.Value;
            lblTarih.Text = "Seçilen Tarih: " + tarih.ToLongDateString();

            DateTime bugun;
            bugun = DateTime.Today;

            yas = bugun.Year - tarih.Year;
            lblYas.Text = "Yaşınız: " + yas;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (yas>=18 && yas<=25)
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
