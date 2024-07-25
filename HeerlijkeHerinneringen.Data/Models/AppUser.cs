using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class AppUser /*: IdentityUser*/
    {
        [ForeignKey("Chef")]
        public int? ChefId { get; set; }
        public Chef? Chef { get; set; }
    }
}
