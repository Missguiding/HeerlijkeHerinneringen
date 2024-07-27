using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Key] public int ReceptBenodigdheidId { get; set; }
        public string? Hoeveelheid { get; set; }
    }
}
