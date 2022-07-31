using BookStore1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.interfaces
{
    public interface IbookRepository
    {
        string Name { get; }
        List<Book> GetAllBooks();
        Book GetBook(int id);
        bool AddNewBook(Book book);

        bool DeleteBook(int id);
    }
}
