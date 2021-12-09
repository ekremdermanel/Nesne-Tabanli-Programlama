using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyeler
{
    public partial class Form1 : Form
    {

        string[] isimler = { "Hakkı Kara", "Necip Akgün", "Hale Kazan", "Binnaz Sarı", "Haydar Güleç", "Abidin Şen", "Sıdıka Cingöz", "Kezban Kıvırcık", "Nuri Bilge", "Serpil Cingöz", "Sabri Kara", "Saniye Tırtıl", "Abuzer Fidan", "Tuğçe Entel", "Fehmi Can Bodur" };
        string[] mailler = { "hakki@gmail.com", "necip@hotmail.com", "hkazan@msn.com", "binnaz1999@gmail.com", "gulechaydar@msn.com", "abi@gmail.com", "cingoz20@gmail.com", "sabrik@hotmail.com", "tirtilcik@yandex.com", "abuzerfidan@yandex.com", "entelkiz@msn.com", "fehmo@gmail.com" };
        string[] sifreler = { "111", "222", "333", "444", "555", "666", "777", "888", "999", "010", "011", "012", "013" , "014" };
        string[] fotolar = { "img0.jpg", "img1.jpg", "img2.jpg", "img3.jpg", "img4.jpg", "img5.jpg", "img6.jpg", "img7.jpg", "img8.jpg", "img9.jpg", "img10.jpg", "img11.jpg", "img12.jpg", "img13.jpg" };
        string[] dogumYerleri = { "Giresun", "Şanlıurfa", "İstanbul", "Hatay", "Tekirdağ", "İstanbul", "Konya", "Çankırı", "Ankara", "Yozgat", "İzmir", "Ankara", "Çankırı", "Yozgat", "Antalya" };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string mail = txtEposta.Text;
            string sifre = txtSifre.Text;

            int indexNo = Array.IndexOf(mailler, mail);
            if (indexNo > -1)
            {
                if (sifreler[indexNo]==sifre)
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                    lblHata.Text = "";
                    txtEposta.Text = "";
                    txtSifre.Text = "";
                    BilgileriGoster(indexNo);
                }
                else
                {
                    lblHata.Text = "Şifre Hatalı";
                }
            }
            else
            {
                lblHata.Text = "Eposta Bulunamadı";
            }
           
        }


        void BilgileriGoster(int id)
        {
            lblAdSoyad.Text = isimler[id];
            lblEposta.Text = mailler[id];
            lblDogumYeri.Text = dogumYerleri[id];
            pbUyeResmi.Image = Image.FromFile("uyeler/" + fotolar[id]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.Left = 10;
            panel2.Top = 10;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }
    }
}
