using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus1_ajoneuvo
{
    class ajoneuvo
    {
        public string nimi { get; set; }

        public int nopeus { get; set; }

        public int renkaat { get; set; }

        public void tulostadata()
        {
            Console.WriteLine("ajoneuvo: ");
            Console.WriteLine("-- nimi: " + nimi);
            Console.WriteLine("-- nopeus: " + nopeus);
            Console.WriteLine("-- renkaat: " + renkaat);
        }


        public string Tostring()
        {
            string merkkijono = "ajoneuvo nimi: " + nimi + ". nopeus + " km/h. renkaat: " renkaat + " kpl;

            return merkkijono;
        }

    
}
