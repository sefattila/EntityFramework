using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroLib
{
    public class Memur : BasePersonel
    {
        const double _saatlikEkstraMesaiUcreti = 250;

        public Memur(string personelId, string personelAd, string personelSoyad, double saatlikUcret, double calismaSaati, string unvan) : base(personelId, personelAd, personelSoyad, saatlikUcret, calismaSaati, unvan)
        {
        }

        public double EkstraMesaiUcreti { get; set; }

        public override double MaasHesapla()
        {
            if (CalismaSaati > 160)
            {
                ToplamMaas = 160 * SaatlikUcret;
                EkstraMesaiUcreti = (CalismaSaati - 160) * _saatlikEkstraMesaiUcreti;
                ToplamMaas += EkstraMesaiUcreti;
                return ToplamMaas;
            }
            else
            {
                ToplamMaas = 160 * SaatlikUcret;
                return ToplamMaas;
            }
        }
    }
}