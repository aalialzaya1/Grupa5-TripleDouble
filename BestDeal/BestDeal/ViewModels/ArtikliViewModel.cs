﻿using BestDeal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.ViewModels
{
    public class ArtikliViewModel
    {
        public Artikal artikal { get; set; }
        public IEnumerable<Artikal> artikli { get; set; }
        public string trenutniTip { get; set; }
    }
}
