using System;

namespace harjoitus_opiskelija
{
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan opiskelian olio
            opiskelija opiskelija1  = new opiskelija("zohar", "TVT22", 0);

            opiskelija1.tulastaData();
            opiskelija1.Muokkaaopintopisteita(10);
            opiskelija1.tulastaData();   
        }
    }
}
