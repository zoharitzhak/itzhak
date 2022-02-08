using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_opiskelija
{
    class opiskelija
    {
        private string Nimi { get; set; }

        private string OpiskelijaID { get; set; }

        private int Opintopisteet { get; set; }
        
            
        // konstuktori opiskelija -luokalle

        public opiskelija(string Nimi, string opiskelijaID, int opintopisteet)
        {
            this.Nimi = Nimi;
            this.OpiskelijaID = OpiskelijaID;
            this.Opintopisteet = Opintopisteet;
        }


        public void tulastaData()
        {
            Console.WriteLine("");
            Console.WriteLine("Opiskelija: ");
            Console.WriteLine("-- Nimi: " + Nimi);
            Console.WriteLine("--OpiskelijaID: " + OpiskelijaID);
            Console.WriteLine("-- Opintopisteet: " + Opintopisteet);
            Console.WriteLine("");
        }

        // metodi, joka ottaa parametriksi integer - arvon.

        public void Muokkaaopintopisteita(int i)
        {
            Opintopisteet += i;

            if (Opintopisteet < 0)
            {
                Opintopisteet = 0;
            }


        }
    }
}
