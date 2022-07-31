using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext() : base("name = BookDbContext")
        {

        }

        public DbSet<BookStore1.Data.Models.Book> Books { get; set; }  
    }
}
