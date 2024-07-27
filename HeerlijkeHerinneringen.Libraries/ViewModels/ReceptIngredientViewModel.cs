using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Libraries.ViewModels
{
    public class ReceptIngredientViewModel
    {
        public string? Eenheid { get; set; }
        public string? Hoeveelheid { get; set; }        

        public IngredientViewModel NaamIngredient { get; set; }
    }
}
