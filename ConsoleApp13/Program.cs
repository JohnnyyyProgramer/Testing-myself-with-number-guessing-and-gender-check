using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite vase ime");
            string Ime = Console.ReadLine();
            Console.WriteLine("Koliko imate godina");
            int godine = int.Parse(Console.ReadLine());
            Console.WriteLine("Kojeg ste pola M/Z");
            string pol = Console.ReadLine();





            if (pol.ToLower() ==  'm'.ToString())
            {
                Console.WriteLine("Musko");


            }
            else
            {
                Console.WriteLine("Zensko");

            }
            Console.WriteLine($"Tvoje ime je {Ime}, ti imas {godine} godina i tvoj pol je {pol} ");
        }
    }   }
