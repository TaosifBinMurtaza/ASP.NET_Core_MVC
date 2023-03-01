﻿using System.ComponentModel.DataAnnotations;

namespace BookManagement.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int TotalOrder { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }

    }
}
