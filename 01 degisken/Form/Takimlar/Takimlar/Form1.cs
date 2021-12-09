using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takimlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGs_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "Galatasaray";
            lblMesaj.BackColor = Color.Red;
            lblMesaj.ForeColor = Color.Yellow;
        }

        private void LblMesaj_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "Fenerbahçe";
        }
    }
}
