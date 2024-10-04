using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_Odev2
{
    class EskenarUcgen : Sekil
    {
        public double UcgenKenar { get; set; }

        public EskenarUcgen(int id, string ad, string renk, double ucgenKenar) : base(id, ad, renk)
        {
            UcgenKenar = ucgenKenar;
        }

        public override double CevreHesapla()
        {
            return UcgenKenar * 3;
        }

        public override double AlanHesapla()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(UcgenKenar, 2);
        }

        public override string BilgiYazdir()
        {
            string bilgi = base.BilgiYazdir() + "\n, Kenar Uzunluğu: " + UcgenKenar;
            bilgi += "\n, Alan: " + AlanHesapla().ToString() + "\n, Çevre: " + CevreHesapla().ToString();
            return bilgi;
        }
    }
}
