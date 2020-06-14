using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komponente;

namespace SHES
{
    public class SHESContext : DbContext
    {
        public DbSet<Baterija> Baterije { get; set; }
        public DbSet<SolarniPanel> Paneli { get; set; }
    }
}
