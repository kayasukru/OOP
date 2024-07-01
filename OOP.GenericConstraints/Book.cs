﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.GenericConstraints
{
    public class Book
    {
        public Book()
        {

        }
        public Book(int id, string title, decimal price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Id,-5} {Title,-20} {Price,-10}";
        }
    }
}
