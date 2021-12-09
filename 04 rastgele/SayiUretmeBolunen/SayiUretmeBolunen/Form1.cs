using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiUretmeBolunen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi;

            while (true)
            {
                sayi = rastgele.Next(1, 101);

                if (sayi % 5 != 0)
                {
                    continue;
                }

                listBox1.Items.Add(sayi);

                if (listBox1.Items.Count==10)
                {
                    break;
                }

            }
        }
    }
}
