using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sehirler
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arananSehir = textBox1.Text;
            int indexNo = Array.IndexOf(sehirler, arananSehir);
            if (indexNo > -1)
            {
                label1.Text = "Plaka Kodu: " + (indexNo + 1);
            }
            else
            {
                label1.Text = "Şehir Bulunamadı";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] secilenSehirler = new string[4];
            Random rastgele = new Random();
            string sehir;
            int sayi, sayac = 0;

            while (sayac<4)
            {
                sayi = rastgele.Next(sehirler.Length);
                sehir = sehirler[sayi];

                if (Array.IndexOf(secilenSehirler,sehir) == -1)
                {
                    secilenSehirler[sayac] = sehir;
                    sayac++;
                }
            }

            Array.Sort(secilenSehirler);

            listBox1.Items.Clear();
            foreach (var item in secilenSehirler)
            {
                listBox1.Items.Add(item);
            }

        }
    }
}
