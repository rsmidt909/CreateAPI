﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiCreation.Models
{
    public class Movie
    {
        [Key]
        public int id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string DirectorName { get; set; }
    }
}