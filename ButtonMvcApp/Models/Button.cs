using System;
using System.ComponentModel.DataAnnotations;

namespace ButtonMvcApp.Models
{
    public class Button
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }

      
        public string ManufactringDate { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}



