using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonsuzDongu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i =0;
            for(; ; )
            {
                i++;
                listBox1.Items.Add(i);


                if(i==10)
                {
                    break;
                }
            }

        }
    }
}
