using BookStore.Data.interfaces;
using BookStore1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Repositories
{
    public class BookRepository : IbookRepository
    {
        public List<Book> books = new List<Book>()
        {
            new Book() {Id = 1, Title = "Harry Potter", Author = "JK Rowling", IsAvailable = true},
            new Book() {Id = 2, Title = "The Walking Dead", Author = "Rick Grimes", IsAvailable= true },
            new Book() {Id = 3, Title = "Spider Man", Author = "Stan Lee", IsAvailable = true},
        };

        public string Name => nameof(BookRepository);

        public bool AddNewBook(Book book)
        {
            books.Add(book);
            return true;
        }

        public bool DeleteBook(int id)
        {
            var book = GetBook(id);
            if (book == null)
            {
                return false;
            }   
            books.Remove(book);
            return true;
           
        }

        public List<Book> GetAllBooks()
        {
           return books;
        }
        public Book GetBook(int id)
        {
            var book = books.First(x => x.Id == id);
            return book;
        }

       
    }
}
