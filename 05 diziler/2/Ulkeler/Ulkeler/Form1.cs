﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ulkeler
{
    public partial class Form1 : Form
    {

        string[] ulkeler = { "Fildişi Sahili", "Birleşik Arap Emirlikleri", "Nijerya", "Gana", "Etiyopya", "Cezayir", "Ürdün", "Hollanda", "Andorra", "Türkiye", "Madagaskar", "Türkmenistan", "Kazakistan", "Paraguay", "Yunanistan", "Irak", "Azerbeycan", "Mali", "Tayland", "Gambiya", "Çin", "Lübnan", "Sırbistan", "Almanya", "İsviçre", "Kırgızistan", "Kolombiya", "Brezilya", "Slovakya", "Kongo Cumhuriyeti", "Belçika", "Romanya", "Macaristan", "Arjantin", "Mısır", "Avustralya", "Venezuela", "Moldova", "Gine", "Danimarka", "Senegal", "Suriye", "Bangladeş", "Katar", "İrlanda", "Tacikistan", "Guatemala", "Vietnam", "Zimbabve", "Küba", "Finlandiya", "Pakistan", "Endonezya", "Filistin", "İsrail", "Afganistan", "Uganda", "Nepal", "Sudan", "Ukrayna", "Ruanda", "Jamaika", "Malezya", "Kuveyt", "Peru", "Portekiz", "Slovenya", "Togo", "Birleşik Krallık", "Angora", "Zambiya", "Lüksemburg", "İspanya", "Maldivler", "Nikaragua", "Bahreyn", "Filipinler", "Mozambik", "Meksika", "Belarus", "Somali", "Monako", "Liberya", "Uruguay", "Rusya", "Umman", "Kenya", "Bahamalar", "Myanmar", "Çad", "Hindistan", "Nijer", "Kıbrıs", "Kuzey Kıbrıs", "Moritanya", "Tonga", "Grönland", "Norveç", "Kanada", "Burkina Faso", "Panama", "Fransa", "Kamboçya", "Karadağ", "Papua Yeni Gine", "Haiti", "Trinidad ve Tobago", "Benin", "Çek Cumhuriyeti", "Güney Afrika", "Kosova", "Kuzey Kore", "Ekvador", "Fas", "İzlanda", "Letonya", "Suudi Arabistan", "İtalya", "Kosta Rika", "Porto Riko", "San Marino", "Yemen", "Şili", "Dominik Cumhuriyeti", "Bosna Hersek", "Güney Kore", "Singapur", "Makedonya Cumhuriyeti", "Bulgaristan", "Sri Lanka", "Grenada", "İsveç", "Bolivya", "Fiji", "Tayvan", "Estonya", "Özbekistan", "Gürcistan", "Honduras", "İran", "Arnavutluk", "Japonya", "Libya", "Tunus", "Moğolistan", "Lihtenştayn", "Malta", "Vatikan Şehri", "Seyşeller", "Avusturya", "Laos", "Litvanya", "Polonya", "Amerika Birleşik Devletleri", "Yeni Zelanda", "Namibya", "Kamerun", "Ermenistan", "Hırvatistan" };

        string [] kitalar = { "Afrika","Asya","Afrika","Afrika","Afrika","Afrika","Asya","Avrupa","Avrupa","Avrupa","Afrika","Asya","Asya","Amerika","Avrupa","Asya","Asya","Afrika","Asya","Afrika","Asya","Asya","Avrupa","Avrupa","Avrupa","Asya","Amerika","Amerika","Avrupa","Afrika","Avrupa","Avrupa","Avrupa","Amerika","Afrika","Okyanusya","Amerika","Avrupa","Afrika","Avrupa","Afrika","Asya","Asya","Asya","Avrupa","Asya","Amerika","Amerika","Afrika","Amerika","Avrupa","Asya","Asya","Asya","Asya","Asya","Afrika","Asya","Afrika","Avrupa","Afrika","Amerika","Asya","Asya","Amerika","Avrupa","Avrupa","Afrika","Avrupa","Afrika","Afrika","Avrupa","Avrupa","Asya","Amerika","Asya","Asya","Afrika","Amerika","Avrupa","Afrika","Avrupa","Afrika","Amerika","Asya","Asya","Afrika","Amerika","Asya","Afrika","Asya","Afrika","Avrupa","Avrupa","Afrika","Afrika","Avrupa","Avrupa","Amerika","Afrika","Amerika","Avrupa","Asya","Avrupa","Afrika","Amerika","Amerika","Afrika","Avrupa","Afrika","Avrupa","Asya","Amerika","Afrika","Avrupa","Avrupa","Asya","Avrupa","Amerika","Amerika","Avrupa","Asya","Amerika","Amerika","Avrupa","Asya","Asya","Avrupa","Avrupa","Asya","Amerika","Avrupa","Amerika","Okyanusya","Asya","Avrupa","Asya","Asya","Amerika","Asya","Avrupa","Asya","Afrika","Afrika","Asya","Avrupa","Avrupa","Avrupa","Afrika","Avrupa","Asya","Avrupa","Avrupa","Amerika","Okyanusya","Afrika","Afrika","Asya","Avrupa" };

        string[] bayraklar = { "ivory coast.png","united arab emirates.png","nigeria.png","ghana.png","ethiopia.png","algeria.png","jordan.png","netherlands.png","andorra.png","turkey.png","madagascar.png","turkmenistan.png","kazakhstan.png","paraguay.png","greece.png","iraq.png","azerbaijan.png","mali.png","thailand.png","gambia.png","china.png","lebanon.png","serbia.png","germany.png","switzerland.png","kyrgyzstan.png","colombia.png","brazil.png","slovakia.png","republic of the congo.png","belgium.png","romania.png","hungary.png","argentina.png","egypt.png","australia.png","venezuela.png","moldova.png","guinea.png","denmark.png","senegal.png","syria.png","bangladesh.png","qatar.png","ireland.png","tajikistan.png","guatemala.png","vietnam.png","zimbabwe.png","cuba.png","finland.png","pakistan.png","indonesia.jpg","palestine.png","israel.png","afghanistan.png","uganda.png","nepal.png","sudan.png","ukraine.png","rwanda.png","jamaica.png","malaysia.png","kuwait.png","peru.png","portugal.png","slovenia.png","togo.png","united kingdom.jpg","angola.png","zambia.jpg","luxembourg.png","spain.png","maldives.png","nicaragua.png","bahrain.png","philippines.png","mozambique.png","mexico.png","belarus.png","somalia.png","monaco.png","liberia.png","uruguay.png","russia.png","oman.png","kenya.png","bahamas.png","myanmar.png","chad.png","india.png","niger.png","cyprus.png","northern cyprus.png","mauritania.png","tonga.png","greenland.png","norway.png","canada.png","burkina faso.png","panama.png","france.png","cambodia.png","montenegro.png","papua new guinea.png","haiti.png","trinidad and tobago.png","benin.png","czech republic.jpg","south africa.jpg","kosovo.png","north korea.gif","ecuador.jpg","morocco.jpg","iceland.png","latvia.png","saudi arabia.png","italy.png","costa rica.jpg","puerto rico.jpg","san marino.png","yemen.png","chile.png","dominican republic.png","bosnia and herzegovina.png","south korea.jpg","singapore.png","republic of macedonia.jpg","bulgaria.png","sri lanka.png","grenada.png","sweden.png","bolivia.png","fiji.png","taiwan.png","estonia.png","uzbekistan.png","georgia.png","honduras.png","iran.png","albania.png","japan.png","libya.png","tunisia.png","mongolia.png","liechtenstein.png","malta.png","vatican city.png","seychelles.png","austria.png","laos.png","lithuania.png","poland.png","united states.png","new zealand.png","namibia.png","cameroon.png","armenia.png","croatia.png" };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] kitalar2 = kitalar.Distinct().ToArray();

            foreach (var item in kitalar2)
            {
                comboBox1.Items.Add(item);
            }

            comboBox1.Items.Insert(0, "Tümü");
            comboBox1.SelectedIndex = 0;

            label3.Text = ulkeler.Length + " ülke listelendi";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int indexNo = listBox1.SelectedIndex;
            int indexNo = Array.IndexOf(ulkeler, listBox1.SelectedItem.ToString());

            label1.Text = ulkeler[indexNo];
            label2.Text = kitalar[indexNo];
            pictureBox1.Image = Image.FromFile("bayraklar/" + bayraklar[indexNo]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string kita = comboBox1.SelectedItem.ToString();
            if (kita == "Tümü")
            {
                foreach (var item in ulkeler)
                {
                    listBox1.Items.Add(item);
                }
            }
            else
            {
                for (int i = 0; i < ulkeler.Length; i++)
                {
                    if (kitalar[i] == kita)
                    {
                        listBox1.Items.Add(ulkeler[i]);
                    }
                }
            }

            listBox1.SelectedIndex = 0;

        }
    }
}
