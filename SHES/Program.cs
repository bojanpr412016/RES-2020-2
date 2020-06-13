using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Komponente;

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

            if (!System.Text.RegularExpressions.Regex.IsMatch("^[0-9]", izbor))
            {
                int x = Int32.Parse(izbor);
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Unesite ime panela: ");
                        string i = Console.ReadLine();
                        Console.WriteLine("Unesite maksimalnu snagu panela: ");
                        int snaga = Int32.Parse(Console.ReadLine());

                        dodavanjePanela(i, snaga);
                        break;
                    case 2:
                        Console.WriteLine("Unesite ime baterije: ");
                        string baterijaIme = Console.ReadLine();
                        


                        break;
                    case 0:
                        
                        break;
                    default:
                        break;
                }

            }
            else
            {
                Console.WriteLine("Morate izabrati jednu od postojecih opcija!");
            }
            void dodavanjePanela(string i, int snaga)
            {
                SolarniPanel sp = new SolarniPanel(i, snaga);

                using (var db = new SHESContex())
                {
                    db.Paneli.Add(sp);
                    db.SaveChanges();
                }
            }

        }

        
    }
}
