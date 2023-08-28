using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroLib
{
    public class Mudur : BasePersonel
    {
        private double _bonus;

        public Mudur(string personelId, string personelAd, string personelSoyad, double saatlikUcret, double calismaSaati, string unvan, double bonus) : base(personelId, personelAd, personelSoyad, saatlikUcret, calismaSaati, unvan)
        {
            this._bonus = bonus;
        }

        public override double MaasHesapla()
        {
            ToplamMaas = 160 * SaatlikUcret;
            ToplamMaas += this._bonus;
            return ToplamMaas;
        }
    }
}
