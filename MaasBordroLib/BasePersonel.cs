using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroLib
{
    public abstract class BasePersonel
    {
        protected BasePersonel(string personelId, string personelAd, string personelSoyad, double saatlikUcret, double calismaSaati, string unvan)
        {
            this.PersonelId = personelId;
            this.PersonelAd = personelAd;
            this.PersonelSoyad = personelSoyad;
            this.SaatlikUcret = saatlikUcret;
            this.CalismaSaati = calismaSaati;
            this.Unvan = unvan;
        }

        public string PersonelId { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string Unvan { get; set; }
        public string PersonelEmail { get; set; }
        public double SaatlikUcret { get; set; }
        public double CalismaSaati { get; set; }
        public double ToplamMaas { get; protected set; }

        public abstract double MaasHesapla();

        public override string ToString()
        {
            return $"{PersonelId} {PersonelAd} {PersonelSoyad} {Unvan} {PersonelEmail} {SaatlikUcret} {CalismaSaati} {ToplamMaas}";
        }
    }
}
