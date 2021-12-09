using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duygular2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenSira;
            secilenSira = comboBox1.SelectedIndex;

            string secilenYazi;
            secilenYazi = comboBox1.SelectedItem.ToString();

            label1.Text = secilenYazi;

            if (secilenSira==0)
            {
                pbResim.Image = Properties.Resources.hicbiri;
            }
            else if (secilenSira==1)
            {
                pbResim.Image = Properties.Resources.mutlu;
            }
            else if (secilenSira == 2)
            {
                pbResim.Image = Properties.Resources.uzgun;
            }
            else if (secilenSira == 3)
            {
                pbResim.Image = Properties.Resources.saskin;
            }
            else if (secilenSira == 4)
            {
                pbResim.Image = Properties.Resources.kizgin;
            }
            else
            {
                pbResim.Image = Properties.Resources.yorgun;
            }
        }
    }
}
