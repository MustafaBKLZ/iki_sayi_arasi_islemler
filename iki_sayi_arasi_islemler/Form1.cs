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
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double sayi1, sayi2;
        bool SayisalKontrolu()
        {
            bool sonuc1, sonuc2;
            try
            {
                sayi1 = Convert.ToDouble(txt_ilk_sayi.Text);
                // convert etmeyi denedik. Eğer hata verirse yani sayı girilmemiş ise
                // formatexception'a düşer ve sayı girilmediğini anlarız
                sonuc1 = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("İlk sayı alanına sadace rakamlar yazabilirsiniz");
                sonuc1 = false;
            }
            try
            {
                sayi2 = Convert.ToDouble(txt_ikinci_sayi.Text);
                // convert etmeyi denedik. Eğer hata verirse yani sayı girilmemiş ise
                // formatexception'a düşer ve sayı girilmediğini anlarız
                sonuc2 = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("İkinci sayı alanına sadace rakamlar yazabilirsiniz");
                sonuc2 = false;
            }

            if (sonuc1 && sonuc2)
            {
                // her iki parametre de sayı ile işleme devam edeceğiz.
                return true;
            }
            else
            {
                return false;
            }
        }
        void ListeyeEkle(object ekle)
        {
            listBox1.Items.Add(ekle);
        }
        private void btn_toplam_ver_Click(object sender, EventArgs e)
        {
            if (SayisalKontrolu())
            {
                double sonuc = 0;
                for (int i = Convert.ToInt32(sayi1); i <= sayi2; i++)
                {
                    sonuc += i;
                    ListeyeEkle(sonuc);
                }
                ListeyeEkle("Sonuç : " + sonuc.ToString());
            }
        }
        private void btn_karelerinin_toplami_Click(object sender, EventArgs e)
        {
            if (SayisalKontrolu())
            {
                double sonuc = 0;
                for (int i = Convert.ToInt32(sayi1); i <= sayi2; i++)
                {
                    sonuc += Math.Pow(i, 2);
                    ListeyeEkle(sonuc + " - " + Math.Pow(i, (Convert.ToInt16(txt_us.Text))));      
                }
                ListeyeEkle("Sonuç : " + sonuc.ToString());
            }
        }




    }
}
