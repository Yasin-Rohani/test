﻿using System.ComponentModel.DataAnnotations;

namespace Bulky2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Displayorder{ get; set; }
    }
}

