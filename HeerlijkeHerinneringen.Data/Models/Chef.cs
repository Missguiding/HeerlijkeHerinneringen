using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class Chef
    {
        public int ChefId { get; set; }
        public string ChefNaam { get; set; }
        public ICollection<Recept> Recepts { get; set; }
    }
}
