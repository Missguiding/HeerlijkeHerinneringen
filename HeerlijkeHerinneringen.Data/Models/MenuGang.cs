﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeerlijkeHerinneringen.Data.Models
{
    internal class MenuGang : BaseEntity
    {
        public ICollection<Recept> recepts { get; set; }
    }
}