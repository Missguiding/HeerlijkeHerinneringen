using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    public class Recept : BaseUsersEntity
    {
        public int ReceptId { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public byte Afbeelding { get; set; }
    }
}
