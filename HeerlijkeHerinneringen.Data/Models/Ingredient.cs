using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public string Eenheid { get; set; }
        public string Hoeveelheid { get; set; }
        
        [ForeignKey("Recept")]
        public int ReceptId { get; set; }
        public Recept Recept { get; set; }       
    }
}
