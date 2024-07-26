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
        public byte?  Afbeelding { get; set; }

        #region List (∞ ReceptIngredient - 1 Recept)
        public ICollection<ReceptIngredient> ReceptIngredients { get; set; }
        #endregion

        #region List (∞ ReceptStap - 1 Recept)
        public ICollection<ReceptStap> ReceptStaps { get; set; }
        #endregion

        #region ForeignKey-MenuGang (∞ Recept - 1 MenuGang)
        [ForeignKey("MenuGang")]
        public int MenuGangId { get; set; }        
        public MenuGang MenuGang { get; set; }
        #endregion

        #region ForeignKey-Temperatuur (∞ Recept - 1 Temperatuur)
        [ForeignKey("Temperatuur")]
        public int TemperatuurId { get; set; }
        public Temperatuur Temperatuur { get; set; }
        #endregion

        #region ForeignKey-TypeGerecht (∞ Recept - 1 TypeGerecht)
        [ForeignKey("TypeGerecht")]
        public int TypeGerechtId { get; set; }
        public TypeGerecht? TypeGerecht { get; set; }
        #endregion

        #region ForeignKey-Chef (∞ Recept - 1 Chef)
        [ForeignKey("Chef")]
        public int ChefId { get; set; }
        public Chef Chef { get; set; }
        #endregion
        public DateTime? AanmaakDatum { get; set; }
        public DateTime? UpdateDatum { get; set; }
        public bool IsDeleted { get; set; }
    }
}
