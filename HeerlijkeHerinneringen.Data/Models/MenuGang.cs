using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class MenuGang
    {
        [Key]
        public int MenuGangId { get; set; }
        public string MenuGangName { get; set; }        
        public ICollection<Recept> Recepts { get; set; }
    }
}
