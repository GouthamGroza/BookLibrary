using BookStore.Data.interfaces;
using BookStore.Data.Models;
using BookStore1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Repositories
{
    public class BookDatabase : IbookRepository
    {
        public BookDbContext db;
        public BookDatabase(BookDbContext _db)
        {
            db = _db;

        }

        public string Name => nameof(BookDatabase);
        public bool AddNewBook(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return true;
        }

        public bool DeleteBook(int id)
        {
            var book = GetBook(id);
            if (book == null)
            {
                return false;
            }

            db.Books.Remove(book);
             db.SaveChanges();
        
            return true;
        }

        public List<Book> GetAllBooks()
        {
            return db.Books.ToList();
        }

        public Book GetBook(int id)
        {
            var book = db.Books.FirstOrDefault(x => x.Id == id);
            return book;
        }
    }
}
