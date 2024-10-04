using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_Odev2
{
    class Daire : Sekil
    {
        public double Cap { get; set; }

        public double Aci { get; set; }

        public Daire(int id, string ad, string renk, double cap, double aci) : base(id, ad, renk)
        { 
            Cap = cap;
            Aci = aci;
        }

        public override double AlanHesapla()
        {
            return (Aci / 360) * Math.PI * Math.Pow(Cap / 2, 2);
        }

        public override double CevreHesapla()
        {
            return (Aci / 360) * 2 * Math.PI * (Cap / 2);
        }

        public override string BilgiYazdir()
        {
            string bilgi = base.BilgiYazdir() + "\n, Çap: " + Cap + "\n, Açı Değeri: " + Aci;
            bilgi += "\n, Alan: " + AlanHesapla().ToString() + "\n, Çevre: " + CevreHesapla().ToString();
            return bilgi;
        }
    }
}
