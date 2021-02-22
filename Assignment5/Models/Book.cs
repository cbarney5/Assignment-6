﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.Models
{
    public class Book
    {//Books Model
        [Key][Required]
       public int BookId { get; set; }
        [Required]
       public string Title { get; set; }
        [Required]
       public string AuthorFirstName { get; set; }
        [Required]
        public string AuthorLastName { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required] //Checks ISBN Format
        [RegularExpression(@"^[0-9]{3}(?:-[0-9]{9})$")]
       public string ISBN { get; set; }
        [Required]
       public string Classification { get; set; }
        [Required]
       public string Category { get; set; }
        [Required]
       public double Price { get; set; }
        [Required]
       public int PageNum { get; set; }


    }
}
