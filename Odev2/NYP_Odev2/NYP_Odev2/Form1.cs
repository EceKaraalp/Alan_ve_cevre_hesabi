using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP_Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //bildirim baloncuğu için gerekli özellikler
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.BalloonTipText = "Programa Hoş Geldiniz!";
            notifyIcon1.BalloonTipTitle = "Nesne Yönelimli Programlama Ödev 1";
            notifyIcon1.Visible = true;
            //ekranda kalması gereken saniyeyi ayarlar
            notifyIcon1.ShowBalloonTip(30000);

        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            string renk = textBoxRenk.Text;


            if (radioButtonDikdortgen.Checked)
            {
                if (double.TryParse(textBox1.Text, out double Genislik) && double.TryParse(textBox2.Text, out double En))
                {
                    Dikdortgen dikdortgen = new Dikdortgen(1, "Dikdörtgen", renk, Genislik, En);
                    ListViewItem sonuc = new ListViewItem(dikdortgen.BilgiYazdir());
                    sonuc.SubItems.Add("Alan: " + dikdortgen.AlanHesapla().ToString("F2"));
                    sonuc.SubItems.Add("Çevre: " + dikdortgen.CevreHesapla().ToString("F2"));
                    listView1.Items.Add(sonuc);
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli kenar değerlerini giriniz.");
                }
            }

            else if (radioButtonUcgen.Checked)
            {

                if (double.TryParse(textBox1.Text, out double UcgenKenar))
                {
                    EskenarUcgen ucgen = new EskenarUcgen(2, "Üçgen", renk, UcgenKenar);

                    ListViewItem sonuc = new ListViewItem(ucgen.BilgiYazdir());
                    sonuc.SubItems.Add("Alan: " + ucgen.AlanHesapla().ToString("F2"));
                    sonuc.SubItems.Add("Çevre: " + ucgen.CevreHesapla().ToString("F2"));
                    listView1.Items.Add(sonuc);
                }
                else
                {
                    MessageBox.Show("Kenar uzunluğu geçerli bir sayı değil.");
                }
            }
            else if(radioButtonDaire.Checked)
            {
                if (double.TryParse(textBox1.Text, out double Cap) &&
                   double.TryParse(textBox2.Text, out double Aci))
                {
                    Daire daire = new Daire(3, "Daire", "Yeşil", Cap, Aci);
                    ListViewItem sonuc = new ListViewItem(daire.BilgiYazdir());
                    sonuc.SubItems.Add("Alan: " + daire.AlanHesapla().ToString("F2"));
                    sonuc.SubItems.Add("Çevre: " + daire.CevreHesapla().ToString("F2"));
                    listView1.Items.Add(sonuc);

                }
                else
                {
                    MessageBox.Show("Çap veya Daire Açısı geçerli bir sayı değil.");
                }
            }
        }

        private void buttonİleri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBoxRenk.Clear();
        }
    }
}
