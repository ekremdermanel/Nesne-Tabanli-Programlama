using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizleGoster2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGizleGoster_Click(object sender, EventArgs e)
        {
            if (btnGizleGoster.Text=="Gizle")
            {
                pbResim.Visible = false;
                btnGizleGoster.Text = "Göster";
            }
            else
            {
                pbResim.Visible = true;
                btnGizleGoster.Text = "Gizle";
            }
            
        }
    }
}
