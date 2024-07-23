using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class Ingrediënt: BaseEntity
    {
        public ICollection<Recept> Recepts { get; set; }
    }
}
