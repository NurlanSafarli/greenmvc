﻿namespace GreenSpecial.Areas.ViewModels
{
    public class CreateMealVM
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public IFormFile Photo { get; set; }
    }
}
