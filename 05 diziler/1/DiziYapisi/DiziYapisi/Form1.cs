using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziYapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim;
            isim = "Ahmet";
            isim = "Ayşe";
            isim = "Osman";

            string[] isimler = new string[3];
            isimler[0] = "Ahmet";
            isimler[1] = "Ayşe";
            isimler[2] = "Osman";

            string[] isimler2 = new string[3] { "Ahmet", "Ayşe", "Osman" };
            isimler2[1] = "Fatma";

            string[] isimler3 = { "Ahmet", "Ayşe", "Osman", "Ömer", "Sibel" };

            label1.Text = "İlk isim:" + isimler3[0];

            for (int i = 0; i < isimler3.Length; i++)
            {
                listBox1.Items.Add(isimler3[i]);
            }

        }
    }
}
