using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Razeni
{
    internal class Prevodovka
    {
        //pole prevodu
        private Prevod[] prevody = new Prevod[6];
        private bool spojka = false; //indikuje stisknuti spojky
        private int otackyMotoru = 0;
        private int otackyVolnobeh;//pokud mame neutral 
        private int aktualniPrevod=-1;//index prevodu co mame zarazeno, neutral bude -1
        private int rychlost = 0;

        public int OtackyMotoru { get { return otackyMotoru; } }
        public int Rychlost { get { return rychlost; } }
        public int AktualniPrevod { get { return aktualniPrevod; } set { aktualniPrevod = value; } }

        public Prevodovka(int otackyVolnoBeh)
        {
            //konstruktor vyuzijeme na inicializaci prevodu
            for (int i = 0; i < prevody.Length; i++)
            {
                prevody[i] = new Prevod(i + 1, 1000);
            }

            this.otackyVolnobeh = otackyVolnoBeh;
        }

        //rozssah rychlomeru bych vydelil 6, na 1 pojedeme max 1/6 maximalni rychlosti
        //otackomer mmaximum na otackomeru vydelime 100 coz je rozsah plynu a pak to vynasobime aktualni hosnotou plynu

        public void MatematikaStavu(int plyn, int maxOtacky, int maxRychlost)
        {
            
            otackyMotoru = plyn * (maxOtacky/100); //100 je max na plynu
            //mame zarazenou rychlost
            if(aktualniPrevod >= 0)
            {//mame zarazeno
                Console.WriteLine("otacky motoru "+otackyMotoru);
                rychlost = (int)(otackyMotoru * (maxRychlost / 6.0 * (aktualniPrevod + 1) / maxOtacky));
                Console.WriteLine("rychlost "+rychlost);
            } 
            else
            {
                //nemame zarazeno
                rychlost = 0;
            }
        }
    }
}
