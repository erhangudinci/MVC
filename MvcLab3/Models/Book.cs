﻿using System.ComponentModel.DataAnnotations;

namespace MvcLab3.Models
{
    public class Book
    {
        [ScaffoldColumn(false)]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        [Range(1,500)]
        public decimal Price { get; set; }
        public string Genre { get; set; }

        [ScaffoldColumn(false)]
        public int AuthorId { get; set; }
        
        public virtual Author Author { get; set; }
    }
}