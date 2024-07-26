using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class Benodigdheid
    {
        [Key]
        public int BenodigdheidId { get; set; }
        public string BenodigdheidNaam { get; set; }

        #region List (∞ ReceptBenodigdheid - 1 Benodigdheid)
        public ICollection<ReceptBenodigdheid> ReceptBenodigdheids { get; set; }
        #endregion
    }
}
