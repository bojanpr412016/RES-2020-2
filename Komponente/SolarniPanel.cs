using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komponente
{
    public class SolarniPanel
    {
        private string ime;
        private int maxSnaga;
        private int trenutnaSnaga;

        public virtual List<SolarniPanel> Paneli { get; set; }
        [Key]
        public string Ime { get => ime; set => ime = value; }
        public int MaxSnaga { get => maxSnaga; set => maxSnaga = value; }
        public int TrenutnaSnaga { get => trenutnaSnaga; set => trenutnaSnaga = value; }

        public SolarniPanel() 
        {
            this.Paneli = new List<SolarniPanel>();
        }

        public SolarniPanel(string i, int ms)
        {
            this.Paneli = new List<SolarniPanel>();
            Ime = i;
            MaxSnaga = ms;
        }
    }
}
