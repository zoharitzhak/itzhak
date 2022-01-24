using System;

namespace harjoitus1_ajoneuvo
{
    class Program
    {
        static void Main(string[] args)
        {
            // olio ajoneuvo -luokasta
            ajoneuvo auto = new ajoneuvo();

            // asetetaan oliolle "auto" arvot 
            auto.nimi = "volvo";
            auto.nopeus = 200;
            auto.renkaat = 4;

            // kaytetaan "auto" olion toimintoja
            auto.tulostadata();

            // noudetetaan auton tiedot Tostring() metodilla
            string autontietot = auto.Tostring();   
            Console.WriteLine(autontietot);

            //tyhja rivi konsoliin
            Console.WriteLine();

            // luodaan toinen olio luokasta ajoneuvo

            ajoneuvo mopo = new ajoneuvo();
            mopo.nimi = "skootteri";
            mopo.nopeus = 100;
            mopo.renkaat = 2;

            mopo.tulostadata();
            Console.WriteLine(mopo.Tostring());
            
        }
    }
}
