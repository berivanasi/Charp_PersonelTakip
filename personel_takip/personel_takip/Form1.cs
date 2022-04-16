using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personel_takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index = 0;
        string[] calısanlar;
        int[] maaslar;
        private void btn_olustur_listele_Click(object sender, EventArgs e)
        {
            calısanlar = new string[] { "Yeşim", "Behzat", "Murat", "Hakan", "Sibel" };
            maaslar = new int[] { 3900, 4800, 2100, 7500, 6200 };
            for(int i = 0; i<calısanlar.Length; i++)
            {
                listBox1.Items.Add(calısanlar[i] + "\t" + maaslar[i]);
            }
        }

        private void btn_lis_temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string aranan = txt_personel.Text;
            bool bulundu = false;
            for(int i =0; i<calısanlar.Length;i++)
            {
                if(aranan==calısanlar[i])
                {
                    bulundu = true;
                    listBox1.SelectedIndex = i;
                    break;
                }
            }
            if(bulundu)
            {
                MessageBox.Show("Çalışan Bulundu");

            }
            else
            {
                MessageBox.Show("Çalışan Bulunamadı");
            }
        }

        private void btn_tpl_prsl_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = "Toplam Personel Sayısı:" + calısanlar.Length;
        }

        private void btn_dsk_maas_Click(object sender, EventArgs e)
        {
            int dusuk = maaslar[0];
            for (int i = 0; i < maaslar.Length; i++)
            {
                if(dusuk> maaslar[i])
                {
                    dusuk = maaslar[i];
                }
            }
            lbl_sonuc.Text = "EN DÜŞÜK MAAŞ:" + dusuk;
        }

        private void btn_yks_maas_Click(object sender, EventArgs e)
        {
            int yuksek= maaslar[0];
            int yuksekIndex = 0;
            for(int i =0; i<maaslar.Length;i++)
            {
                if (yuksek < maaslar[i]) 
                {
                    yuksek = maaslar[i];
                    yuksekIndex = i;
                }
            }
            lbl_sonuc.Text = "En Yüksek Maaş Alan :" + calısanlar[yuksekIndex];

        }

        private void btn_maas_4000_az_olan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i] < 4000)
                {
                    listBox1.Items.Add(calısanlar[i] + ">>" + maaslar[i]);
                }
            }
        }

        private void btn_mas_4_7_arası_Click(object sender, EventArgs e)
        {
            for (int a = 0;  a < maaslar.Length; a++)
            {
                if (maaslar [a]> 5000 && maaslar[a]<7000)

                {
                    listBox1.Items.Add(calısanlar[a] + ">>" + maaslar[a]);
                }
            }
        }

        private void btn_tplm_maas_Click(object sender, EventArgs e)
        {
            int toplam = 0;
             for(int i=0; i< maaslar.Length; i++)
            {
                toplam = toplam + maaslar[i];
            }
            lbl_sonuc.Text = "Toplam Maaş" + toplam;
        }

        private void btn_maas_3_elmn_arttır_Click(object sender, EventArgs e)
        {
            maaslar[2] = maaslar[2] + 500;
            lbl_sonuc.Text = "Yeni Maaş:" + maaslar[2];
            listBox1.Items[2] = calısanlar[2] + "\t" + maaslar[2];

        }

        private void btn_son_prs_ad_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text ="Son Personel :" +calısanlar [calısanlar.Length -1];
            MessageBox.Show("Son Personel :" + calısanlar[4]);
        }
    }
}
