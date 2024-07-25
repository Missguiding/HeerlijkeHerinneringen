using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class Temperatuur 
    {
        [Key]
        public int TemperatuurId { get; set; }
        public string ITemperatuurName { get; set; }

        #region List (∞ Recept - 1 Temperatuur)
        public ICollection<Recept> Recepts { get; set; }
        #endregion
    }
}
