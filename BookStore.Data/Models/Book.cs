using BookStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore1.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }


       // public int? CustomerId { get; set; }

       // public CustomerDetails Customer { get; set }

    }
}