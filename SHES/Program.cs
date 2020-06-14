using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Komponente;
using System.Diagnostics;
using SnagaSuncaForma;
using System.Windows.Forms;


namespace SHES
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                string izbor = "";
                Console.WriteLine("Unesite opciju:");
                Console.WriteLine("1. Dodaj solarni panel");
                Console.WriteLine("2. Dodaj bateriju");
                Console.WriteLine("3. Izmeni snagu sunca");
                Console.WriteLine("0. Izlaz");
                izbor = Console.ReadLine();
                Metode m = new Metode();
                SolarniPanel panel = new SolarniPanel();

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

                            m.dodavanjePanela(i, snaga);

                            break;
                        case 2:

                            Console.WriteLine("Unesite ime baterije:");
                            string baterijaIme = Console.ReadLine();

                            Console.WriteLine("Unesite maksimalnu snagu baterije:");
                            int maxSnaga = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("Unesite kapacitet baterije:");
                            int kapacitet = Int32.Parse(Console.ReadLine());

                            m.dodavanjeBaterije(baterijaIme, maxSnaga, kapacitet);

                            break;
                        case 3:
                            SnagaSuncaForm ss = new SnagaSuncaForm();

                            ss.Show();

                            
                            

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
            }
            
            

        }

        
    }
}
