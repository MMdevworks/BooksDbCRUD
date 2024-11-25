﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1BooksDbCRUD.Models
{
    public class Book
    {
        public string ISBNid { get; set; }
        public string Title { get; set; }
        public string? Name { get; set; }
        public string Description {  get; set; }
        public int Stock {  get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null;
    }
}