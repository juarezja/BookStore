﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.DTOs
{
    public class AuthorDTO
    {
        public int AuthorId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Bio { get; set; }
        public virtual IList<BookDTO> Books { get; set; }
    }
    public class AuthorCreateDTO
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Bio { get; set; }
    }
    public class AuthorUpdateDTO
    {
        public int AuthorId { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Bio { get; set; }
    }
}
