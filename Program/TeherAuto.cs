using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class TeherAuto : Jarmu
    {
        private int rakomany;

        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomany) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            this.Rakomany = rakomany;
        }

        public int Rakomany { get => rakomany; 
            set {
                rakomany = Math.Clamp(value, 0, 20);
            } }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{base.Rendszam} - {base.Kor} éves jármű, {base.KilometerOra} km-rel, rakomany {rakomany} tonna");
        }

        public override void Szervizel(int dij)
        {
            rakomany = 0;
            Console.WriteLine("Rakomany lepakolva!");
            base.Szervizel(dij);
        }
    }
}
