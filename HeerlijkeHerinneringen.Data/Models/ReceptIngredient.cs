using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class ReceptIngredient
    {
        #region Key --> Recept --> Ingredient
        public int ReceptId { get; set; }
        public Recept Recept { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        #endregion

        public string Eenheid { get; set; }
        public string Hoeveelheid { get; set; }
    }
}
