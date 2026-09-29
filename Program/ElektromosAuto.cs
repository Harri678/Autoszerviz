using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumulatorSzint) : base(rendszam, kor, kilometerOra, 0)
        {
            this.AkkumulatorSzint = akkumulatorSzint;
        }
        public int AkkumulatorSzint { get => akkumulatorSzint; 
            set {
                akkumulatorSzint = Math.Clamp(value, 0, 100);
            } }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{base.Rendszam} - {base.Kor} éves jármű, {base.KilometerOra} km-rel akkumlator szint {akkumulatorSzint}% töltöttseggel");
        }


        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                base.KilometerOra -= 10000;
            }
            akkumulatorSzint += 20;
            Console.WriteLine("A jarmu szervizelése megtortent");
        }
    }
}
