using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class TypeGerecht 
    {
        [Key]
        public int TypeGerechtId { get; set; }
        public string TypeGerechtName { get; set; }
        public ICollection<Recept> Recepts { get; set; }
    }
}
