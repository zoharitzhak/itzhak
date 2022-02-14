using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus3_kiuas
{
    class Program
    {
        static void Main(string[] args)
        {
            kiuas kiuas1 = new kiuas(0,0,false);

            while (true)
            {

                kiuas1.tulasta();

                string asetus = Console.ReadLine();

                if (asetus.Equals("1"))

                {
                    kiuas1.paalle();
                }
                else if (asetus.Equals("2"))

                {
                    kiuas1.nostalampo();
                }
                else if (asetus.Equals("3"))

                {
                    kiuas1.laskelampo();
                }
                else if (asetus.Equals("4"))

                {
                    kiuas1.heitaloyly();
                }  
                else if (asetus.Equals("4"))

                {
                    break;
                }
            }
        }
    }
}
