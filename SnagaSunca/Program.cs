using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komponente;
using SHES;

namespace SnagaSunca
{
    public class Program 
    {
        static void Main(string[] args)
        {
            SolarniPanel sp = new SolarniPanel();
            Metode m = new Metode();

            Console.WriteLine("Lista panela:" + Environment.NewLine);

            foreach(SolarniPanel panel in sp.Paneli)
            {
                Console.WriteLine("Ime panela: " + panel.Ime.ToString() + Environment.NewLine);
            }

            Console.WriteLine("Unesite ime panela za koji zelite da promenite snagu sunca: ");
            string imePanela = Console.ReadLine();
            

            Console.WriteLine("Unesite snagu sunca za zadati panel: ");
            int snagaSunca = Int32.Parse(Console.ReadLine());

            m.trenutnaSnagaPanela(imePanela, snagaSunca);

        }
    }
}
