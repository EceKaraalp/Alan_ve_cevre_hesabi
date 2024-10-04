using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_Odev2
{
    class Sekil
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public string Renk { get; set; }

        public Sekil(int id, string ad, string renk)
        {
            Id = id;
            Ad = ad;
            Renk = renk;
        }

        public virtual double AlanHesapla()
        {
            return 0;
        }

        public virtual double CevreHesapla()
        {
            return 0;
        }

        public virtual string BilgiYazdir()
        {
            return "ID: " + Id 
                + "\n, Şeklin Adı: " + Ad 
                + "\n, Şeklin Rengi: " + Renk;
        }
    }
}
