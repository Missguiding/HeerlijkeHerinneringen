using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class Recept
    {
        [Key]
        public int ReceptId { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public byte Afbeelding { get; set; }
        
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Chef> Chefs { get; set; }

        [ForeignKey("MenuGang")]
        public int MenuGangId { get; set; }
        public MenuGang MenuGang { get; set; }

        [ForeignKey("Temperatuur")]
        public int TemperatuurId { get; set; }
        public Temperatuur Temperatuur { get; set; }

        [ForeignKey("TypeGerecht")]
        public int TypeGerechtId { get; set; }
        public TypeGerecht TypeGerecht { get; set; }
        
        public DateTime AanmaakDatum { get; set; }
        public DateTime UpdateDatum { get; set; }
        public bool IsDeleted { get; set; }
    }
}
