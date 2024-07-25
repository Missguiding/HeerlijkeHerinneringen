using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class Afbeelding
    {
        [Key]
        public int AfbeeldingId { get; set; }

        public string AfbeeldingNaam { get; set; }

        public string? AfbeeldingUrl  { get; set; }       

        #region ForeignKey-Recept (∞ Afbeelding - 1 Recept)

        [ForeignKey("Recept")]
        public int ReceptId { get; set; }
        public Recept Recept { get; set; }
        #endregion
    }    
}

