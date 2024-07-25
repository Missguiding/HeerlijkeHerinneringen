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
       
        [ForeignKey("Recept")]
        public int ReceptId { get; set; }
        public Recept Recept { get; set; }
    }
}
