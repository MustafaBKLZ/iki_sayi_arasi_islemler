using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iki_sayi_arasi_islemler
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) { }
        void ListeyeEkle(object ekle) { listBox1.Items.Add(ekle); }
        void ListeTemizle() { listBox1.Items.Clear(); }


        double sayi1 = 0, sayi2 = 0;
        bool SayisalKontrol()
        {
            bool sayik1 = false, sayik2 = false;
            try
            {
                sayi1 = Convert.ToDouble(txt_ilk_sayi.Text);
                sayik1 = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("İlk sayı alanına girilen değer sayısal bir değer değildir. Lütfen sayısal bir değer giriniz.");
            }
            try
            {
                sayi2 = Convert.ToDouble(txt_ikinci_sayi.Text);
                sayik2 = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("İkinci sayı alanına girilen değer sayısal bir değer değildir. Lütfen sayısal bir değer giriniz.");
            }
            return sayik1 && sayik2;
        }
        private void btn_toplam_ver_Click(object sender, EventArgs e)
        {
            ListeTemizle();
            if (SayisalKontrol())
            {
                double sonuc = 0;
                for (double i = sayi1; i <= sayi2; i++)
                {
                    sonuc += i;
                    ListeyeEkle(sonuc);
                }
                ListeyeEkle("Sonuç : " + sonuc.ToString());
            }
        }
        private void btn_karelerinin_toplami_Click(object sender, EventArgs e)
        {
            ListeTemizle();
            if (SayisalKontrol())
            {
                double sonuc = 0, islem = 0;
                for (double i = sayi1; i <= sayi2; i++)
                {
                    islem = Math.Pow(i, Convert.ToInt16(txt_us.Text));
                    sonuc += islem;
                    ListeyeEkle(sonuc.ToString() + " - " + i.ToString() + " üzeri " + txt_us.Text + " = " + islem.ToString());
                }
                ListeyeEkle("Sonuç : " + sonuc.ToString());
            }
        }



        private void btn_asal_olanlari_ver_Click(object sender, EventArgs e)
        {
            ListeTemizle();
            if (SayisalKontrol())
            {
                double kontrol = 0, sonuc = 0;
                for (double i = sayi1; i <= sayi2; i++)
                {
                    kontrol = 0;
                    for (int ii = 2; ii < i; ii++)
                    {
                        if (i % ii == 0)
                        {
                            kontrol++;
                            break;
                        }
                    }
                    if (kontrol != 0)
                    {
                        //ListeyeEkle(i.ToString() + " sayısı ASAL Değildir");
                    }
                    else
                    {
                        sonuc += i;
                        ListeyeEkle(i.ToString() + " sayısı ASALdır");
                    }
                }
                ListeyeEkle("Asalların Toplamaı : " + sonuc.ToString());
            }
        }


        private void btn_sayilara_bolunebilenler_Click(object sender, EventArgs e)
        {
            string[] bolenler = txt_bolenler.Text.Split(',');// 2,3,4,5
            // 2
            // 3
            // 4
            // 5

            int[] tutanlar; //60
            // 1
            // 1
            // 1
            // 1

            int tutan_adet = 0;
            // 4

            ListeTemizle();
            if (SayisalKontrol())
            {
                for (double i = sayi1; i <= sayi2; i++)
                {
                    tutan_adet = 0;
                    tutanlar = new int[bolenler.Count()];

                    for (int j = 0; j < bolenler.Count(); j++)
                    {
                        if (i % Convert.ToInt16(bolenler[j]) == 0)
                            tutanlar[j] = 1;
                        else
                            tutanlar[j] = 0;
                    }
                    for (int k = 0; k < tutanlar.Count(); k++)
                    {
                        if (tutanlar[k] == 1)
                            tutan_adet++;
                    }

                    if (bolenler.Count() == tutan_adet)
                        ListeyeEkle("Tüm bölenlere tam bölünebilen sayı : " + i.ToString());

                }
            }
        }



    }
}
