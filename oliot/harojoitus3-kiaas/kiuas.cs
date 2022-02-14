using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus3_kiuas
{
     class kiuas
    {
        private int kosteus;

        private int lampotila;

        private Boolean tila;

        public kiuas(int _kost, int _lamp, Boolean _tila)

        {
            kosteus = _kost;

            lampotila = _lamp;

            tila = _tila;
        }


        public void paalle()
        {
            if (tila == true)
            {
                tila = false;
                Console.WriteLine("kiuas on nyt pois paalta");

            }
            if (tila == false)
            {
                tila = true;
                Console.WriteLine("kiuas on nyt paalla");

            }

        }
        public void nostalampo()
        {
            lampotila = +5;
        }
        public void laskelampo()
        {
            lampotila = -5;

        }
        public void heitaloyly()
        {
            kosteus = +5;

        }
        public void tulasta()
        {
            Console.WriteLine("kiukaan tiedot:");
            if (tila == true)
            {
                Console.WriteLine("kiuas on paalla");
            }
            else if (tila == false)
            {
                Console.WriteLine("kiuas on pois paalta");
            }
            Console.WriteLine("kiukaan lampotila:" + lampotila + " astetta");
            Console.WriteLine("kiukaan kosteus:" + kosteus + " prosenttia");




        }










    }
}
