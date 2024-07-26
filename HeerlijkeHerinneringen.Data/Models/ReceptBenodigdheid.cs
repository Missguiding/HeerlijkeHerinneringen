using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class ReceptBenodigdheid
    {
        #region Key --> Recept --> Benodigdheid
        public int ReceptId { get; set; }
        public Recept Recept { get; set; }

        public int BenodigdheidId { get; set; }
        public Benodigdheid Benodigdheid { get; set; }
        #endregion

        public string? Hoeveelheid { get; set; }
    }
}
