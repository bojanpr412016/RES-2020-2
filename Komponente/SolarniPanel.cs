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
        private List<SolarniPanel> paneli = new List<SolarniPanel>();

        [Key]
        public string Ime { get => ime; set => ime = value; }
        public int MaxSnaga { get => maxSnaga; set => maxSnaga = value; }
        public int TrenutnaSnaga { get => trenutnaSnaga; set => trenutnaSnaga = value; }
        public List<SolarniPanel> Paneli { get => paneli; set => paneli = value; }

        public SolarniPanel(){}

        public SolarniPanel(string i, int ms)
        {
            
            Ime = i;
            MaxSnaga = ms;
        }
    }
}
