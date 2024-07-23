using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class ReceptIngrediënt
    {
        public int ReceptIngrediëntId { get; set; }
        public string Eenheid { get; set; }
        public string Hoeveelheid { get; set; }
        public Recept recept { get; set; }
        public Ingrediënt ingrediënt { get; set; }
    }
}
