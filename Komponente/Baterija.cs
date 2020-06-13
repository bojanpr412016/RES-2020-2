using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komponente
{
    public class Baterija
    {
        private string ime;
        private int maksimalnaSnaga;
        private int kapacitet;

        public List<Baterija> Baterije { get; set; }
        [Key]
        public string Ime { get => ime; set => ime = value; }
        public int MaksimalnaSnaga { get => maksimalnaSnaga; set => maksimalnaSnaga = value; }
        public int Kapacitet { get => kapacitet; set => kapacitet = value; }
        
        public Baterija()
        {
        }

        public Baterija(string ime, int maksimalnaSnaga, int kapacitet)
        {
            Ime = ime;
            MaksimalnaSnaga = maksimalnaSnaga;
            Kapacitet = kapacitet;
        }

    }
}
