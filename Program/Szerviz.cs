using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Szerviz
    {
        private List<Jarmu> jarmuList = new List<Jarmu>();

        public void JarmuFelvetele(Jarmu jarmu)
        {
            jarmuList.Add(jarmu);
            Console.WriteLine($"A jarmu megérkezett a szervizbe ({jarmu.Rendszam})");
        }

        public void InformaciokListazasa()
        {
            foreach(Jarmu jarmu in jarmuList)
            {
                jarmu.InformaciotAd();
            }
        }

        public void CsoportosSzerviz(int dij)
        {
            foreach (Jarmu jarmu in jarmuList)
            {
                if(jarmu.SzervizSzukseges == true)
                {
                    jarmu.Szervizel(dij);
                }
                else
                {
                    Console.WriteLine($"A {jarmu.Rendszam} szervizelese jelenleg nem szukseges");
                }
            }
        }

    }
}
