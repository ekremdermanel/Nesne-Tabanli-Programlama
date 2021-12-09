using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futbolcular
{
    public partial class Form1 : Form
    {
        string[] futbolcular = {"Baggio","Beckenbauer","Buffon","Cristiano Ronaldo","Hagi",
        "Ibrahimovic","Maradona","Lionel Messi","Neymar","Pele","Platini","Ronaldinho","Ronaldo",
        "Sabri","Van Basten","Zidane"};
        string[] resimler = {"baggio.jpg","beckenbauer.jpg","buffon.jpg","cristiano_ronaldo.jpg","hagi.jpg",
        "ibrahimovic.jpg","maradona.jpg","messi.jpg","neymar.jpg","pele.jpg","platini.jpg",
        "ronaldinho.jpg","ronaldo.jpg","sabri.jpg","van_basten.jpg","zidane.jpg"};
        int sayac = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in futbolcular)
            {
                listBox1.Items.Add(item);
            }
            listBox1.SelectedIndex = 0;

            Goster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac++;
            listBox1.SelectedIndex = sayac;
            Goster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac--;
            listBox1.SelectedIndex = sayac;
            Goster();
        }

        void Goster()
        {
            label1.Text = futbolcular[sayac];
            pictureBox1.Image = Image.FromFile("futbolcular/" + resimler[sayac]);

            if (sayac == 0)
            {
                button1.Enabled = false;
            }
            else if (sayac == futbolcular.Length - 1)
            {
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sayac = listBox1.SelectedIndex;
            Goster();
        }
    }
}
