using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class BaseEntity
    {
        [Key]
        public int baseId { get; set; }
        public string Name { get; set; }
    }
}
