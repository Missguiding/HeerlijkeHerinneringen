using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class Temperatuur : BaseEntity
    { 
        public ICollection<Recept> Recepts { get; set; }
    }
}
