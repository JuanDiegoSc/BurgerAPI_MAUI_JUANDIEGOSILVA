﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAPI_MAUI_JUANDIEGOSILVA.Models
{
    public class Burger
    {
        public int burgerId { get; set; }
        public string? name { get; set; }
        public bool withCheese { get; set; }
        public decimal precio { get; set; }
        public List<object>? promos { get; set; }
    }
 
}
