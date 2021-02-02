﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.DTOs
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }
        public string Isbn { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public decimal? Price { get; set; }
        public int AuthorId { get; set; }
        public virtual AuthorDTO Author { get; set; }
    }
    public class BookCreateDTO
    {
        public string Title { get; set; }
        public int? Year { get; set; }
        public string Isbn { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public decimal? Price { get; set; }
        public int AuthorId { get; set; }
        public virtual AuthorDTO Author { get; set; }
    }
    public class BookUpdateDTO
    {
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        public int? Year { get; set; }
        [StringLength(500)]
        public string Summary { get; set; }
        public string Image { get; set; }
        public decimal? Price { get; set; }
        public int? AuthorId { get; set; } // Missing from the previous lesson. Ensure that you include.
    }
}