﻿using System;
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

        private string proba = "";

        public virtual List<SolarniPanel> Paneli { get; set; }
        [Key]
        public string Ime { get => ime; set => ime = value; }
        public int MaxSnaga { get => maxSnaga; set => maxSnaga = value; }
        public int TrenutnaSnaga { get => trenutnaSnaga; set => trenutnaSnaga = value; }

        public SolarniPanel(){}

        public SolarniPanel(string i, int ms)
        {
            
            Ime = i;
            MaxSnaga = ms;
        }
    }
}
