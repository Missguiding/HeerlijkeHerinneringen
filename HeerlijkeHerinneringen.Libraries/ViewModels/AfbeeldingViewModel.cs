using HeerlijkeHerinneringen.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Libraries.ViewModels
{
    public class AfbeeldingViewModel
    {
        public int AfbeeldingId { get; set; }
        public string? AfbeeldingNaam { get; set; }
        public string? AfbeeldingUrl { get; set; }    
        
        public int ReceptId { get; set; }
    }
}
