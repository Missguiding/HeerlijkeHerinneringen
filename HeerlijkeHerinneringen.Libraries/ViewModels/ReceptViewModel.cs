using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Libraries.ViewModels
{
    public class ReceptViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Beschrijving { get; set; }
        public byte? Afbeelding { get; set; }
    }
}
