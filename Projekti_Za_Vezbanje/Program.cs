using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti_Za_Vezbanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int i = random.Next(0, 101);
            bool pobeda = false;

            do
            {
                Console.WriteLine("Pogodi broj");
                string s = Console.ReadLine();
                int p = int.Parse(s);
                if (p > i)
                {
                    Console.WriteLine("Broj je prevelik, probaj ponovo");
                }
                else if (p < i)
                {
                    Console.WriteLine("broj je prenizak, probaj ponovo");

                }
                else if (p == i) 
                {
                    Console.WriteLine("Pogodio si, Svaka Cast");
                    pobeda = true;

                }
            } while (pobeda == false);

            
            
           
        }
    }
}
