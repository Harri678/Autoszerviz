using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Busz : Jarmu
    {
        private int utasokSzama;

        public Busz(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int utasokSzama) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            this.UtasokSzama = utasokSzama;
        }

        public int UtasokSzama { get => utasokSzama; 
            set{
                utasokSzama = Math.Clamp(value, 0, 30);
            } }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{base.Rendszam} - {base.Kor} éves jármű, {base.KilometerOra} km-rel, utasok szama {utasokSzama}");
        }

        public override void Szervizel(int dij)
        {
            utasokSzama = 0;
            Console.WriteLine("Az utasok leszalltak");
            base.Szervizel(dij);
        }
    }
}
