using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_Odev2
{
    class Dikdortgen : Sekil 
    {
        public double Genislik { get; set; }

        public double En { get; set; }

        public Dikdortgen(int id, string ad, string renk, double genislik, double en) : base(id, ad, renk)
        {
            Genislik = genislik;
            En = en;
        }

        public override double AlanHesapla()
        {
            double alan = Genislik * En;
            return alan;
        }

        public override double CevreHesapla()
        {
            double cevre = 2 * (Genislik + En);
            return cevre;
        }

        public override string BilgiYazdir()
        {
            string bilgi = base.BilgiYazdir() + "\n, Uzun Kenar: " + Genislik + "\n, Kısa Kenar: " + En;
            bilgi += "\n, Alan: " + AlanHesapla().ToString() + "\n, Çevre: " + CevreHesapla().ToString();
            return bilgi;

        }
    }
}
