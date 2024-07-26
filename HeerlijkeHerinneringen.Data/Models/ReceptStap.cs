using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class ReceptStap
    {
        [Key]
        public int ReceptStapId { get; set; }
        public int Volgorde { get; set; }
        public string Beschrijving { get; set; }

        #region ForeignKey-Recept (∞ ReceptStap - 1 Recept)
        [ForeignKey("Recept")]
        public int ReceptId { get; set; }
        public Recept Recept { get; set; }
        #endregion
    }
}
