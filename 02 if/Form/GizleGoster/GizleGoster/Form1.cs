using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizleGoster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGizle_Click(object sender, EventArgs e)
        {
            pbResim.Visible = false;
            btnGizle.Enabled = false;
            btnGoster.Enabled = true;
        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            pbResim.Visible = true;
            btnGoster.Enabled = false;
            btnGizle.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGoster.Enabled = false;
        }
    }
}
