using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class Recept : BaseUsersEntity
    {
        public int ReceptId { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public byte Afbeelding { get; set; }
        public int IngredientId { get; set; }
        public Ingrediënt Ingrediënt { get; set; }
        public int MenuGangId { get; set; }
        public MenuGang MenuGang { get; set; }  
        public int TypeGerechtId { get; set; }  
        public TypeGerecht TypeGerecht { get; set; }
        public int TemperatuurId { get; set; }
        public Temperatuur temperatuur { get; set; }
    }
}
