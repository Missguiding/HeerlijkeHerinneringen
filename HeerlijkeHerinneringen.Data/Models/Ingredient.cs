﻿using System;
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

        #region List (∞ ReceptIngredient - 1 Ingredient)
        public ICollection<ReceptIngredient> ReceptIngredients { get; set; }
        #endregion
    }
}
