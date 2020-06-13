using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SHES
{
    class Program
    {
        static void Main(string[] args)
        {
            string izbor = "";
            Console.WriteLine("Unesite opciju:");
            Console.WriteLine("1. Dodaj solarni panel");
            Console.WriteLine("2. Dodaj bateriju");
            Console.WriteLine("0. Izlaz");
            izbor = Console.ReadLine();

            if (System.Text.RegularExpressions.Regex.IsMatch("^[0-9]", izbor))
            {
                int x = Int32.Parse(izbor);
                switch (x)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 0:
                        
                        break;
                    default:
                        break;
                }

            }


        }
    }
}
