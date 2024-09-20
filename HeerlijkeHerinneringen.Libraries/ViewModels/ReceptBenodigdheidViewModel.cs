using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Libraries.ViewModels
{
    public class ReceptBenodigdheidViewModel
    {
        public int Id { get; set; }
        public string? Hoeveelheid { get; set; }
        public BenodigdheidViewModel Benodigdheid { get; set; }

    }
}
