using HeerlijkeHerinneringen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Libraries.ViewModels
{
    public class ReceptViewModel
    {
        public int Id { get; set; }
        public string ChefVoorNaam { get; set; }
        public string ChefFamilieNaam { get; set; }
        public string Titel { get; set; }
        public string MenuGang { get; set; }
        public string Temperatuur { get; set; }
        public string TypeGerecht { get; set; }

        public string AfbeeldingPad { get; set; }
        public ICollection<AfbeeldingViewModel> Afbeeldingen { get; set; }
        public List<ReceptStapViewModel> ReceptStaps { get; set; }
        public List<ReceptBenodigdheidViewModel> ReceptBenodigdheids { get; set; } 
        public List<ReceptIngredientViewModel> ReceptIngredients { get; set; }
    }
}
