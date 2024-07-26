using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class Benodigdheid
    {
        [Key]
        public int BenodigdheidId { get; set; }
        public string Naam { get; set; }

        #region ForeignKey-Recept (∞ Benodigdheid - 1 Recept)
        [ForeignKey("Recept")]
        public int ReceptId { get; set; }
        public Recept Recept { get; set; }
        #endregion
    }
}
