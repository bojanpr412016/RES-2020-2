using Komponente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHES
{
    public class Metode : IMetode
    {
        public void dodavanjeBaterije(string i, int ms, int k)
        {

                Baterija b = new Baterija(i, ms, k);

                using (var db = new SHESContex())
                {
                    db.Baterije.Add(b);
                    db.SaveChanges();
                Console.WriteLine("Baterija uspesno dodata!");
                }
        }


        

        public void dodavanjePanela(string i, int snaga)
        {

            SolarniPanel sp = new SolarniPanel(i, snaga);

            using (var db = new SHESContex())
            {
                db.Paneli.Add(sp);
                db.SaveChanges();
                Console.WriteLine("Solarni panel uspesno dodat!");

            }

        }
    }
}
