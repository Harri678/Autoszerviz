using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        private string rendszam;
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;
        private bool szervizSzukseges;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            this.Rendszam = rendszam;
            this.Kor = kor;
            this.KilometerOra = kilometerOra;
            this.UzemanyagSzint = uzemanyagSzint;
            this.SzervizSzukseges = false;
        }

        public string Rendszam { 
            
            get => rendszam; 
            set
            {
                if (string.IsNullOrWhiteSpace(value)) {
                    rendszam = "ISMERETLEN";
                }
                else
                {
                    rendszam = value;
                }
            } }

        public int Kor { 
            get => kor;
            set {
                kor = Math.Clamp(value, 0, 50); 
            }
        }
        public int KilometerOra
        {
            get => kilometerOra;
            set
            {
                if(value < 0)
                {
                    kilometerOra = 0;
                }
                else
                {
                    kilometerOra = value;
                }
            }
        }
        public int UzemanyagSzint { get => uzemanyagSzint;
            set {
                uzemanyagSzint = Math.Clamp(value, 0, 100);
            } }
        public bool SzervizSzukseges { get => szervizSzukseges;
            set {
                if(kilometerOra >= 200000)
                {
                    szervizSzukseges = true;
                }
                else
                {
                    szervizSzukseges = false;
                }
            } }

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{rendszam} - {kor} éves jármű, {kilometerOra} km-rel");
        }

        public void Szervizel(int dij)
        {
            if(dij > 100000)
            {
                kilometerOra -= 10000;
            }
                uzemanyagSzint -= 10;
                Console.WriteLine("A jarmu szervizelése megtortent");
        }


    }
}
