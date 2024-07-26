﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Libraries.ViewModels
{
    public class ReceptViewModel
    {
        public int Id { get; set; }
        public string Chef { get; set; }
        public string Titel { get; set; }
        public string MenuGang { get; set; }
        public string Temperatuur { get; set; }
        public string TypeGerecht { get; set; }       
        public byte? Afbeelding { get; set; }
        public List<ReceptStapViewModel> ReceptStaps { get; set; }
        public List<BenodigdheidViewModel> Benodigdheids { get; set; }
    }
}
