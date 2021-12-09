using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakaSehirSorusu
{
    public partial class Form1 : Form
    {

        string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
"Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
"Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir",
"Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
"Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya",
"Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
"Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak",
"Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak",
"Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };
        
        int sayi,plaka, puan=0, can=10; 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YeniSoru();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cevap = textBox1.Text;

            if (cevap == sehirler[sayi])
            {
                pictureBox1.Image = Properties.Resources.dogru;
                label4.Text = "Doğru Cevap!";
                puan += 10;
                label2.Text = "Puan: " + puan;

                YeniSoru();
            }
            else
            {
                pictureBox1.Image = Properties.Resources.yanlis;
                label4.Text = "Yanlış Cevap!";
                can--;
                label3.Text = "Can: " + can;

                if (can==0)
                {
                    Application.Exit();
                }
            }
        }

        void YeniSoru()
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(sehirler.Length);
            plaka = sayi + 1;
            label1.Text = plaka + " plaka numaralı şehir hangisidir?";
            label1.Text += sehirler[sayi];
        }
    }
}
