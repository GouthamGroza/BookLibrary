using BookStore.Data.interfaces;
using BookStore.Data.Repositories;
using BookStore1.Data.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BookStore1.Controllers
{
    public class BookController : ApiController
    {
        public IbookRepository books;

        public BookController(IEnumerable<IbookRepository> _books)
        {
            var respositoryName = ConfigurationManager.AppSettings["DbRepositoryName"];
            this.books = _books.FirstOrDefault(b => b.Name == respositoryName);
        }

        // GET api/book
        public IEnumerable<Book> Get()
        {
            return books.GetAllBooks();
        }

        // GET api/book/5
        public IHttpActionResult Get(int id)
        {
            var book = books.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        public IHttpActionResult PostBook(Book book)
        {
            bool result = books.AddNewBook(book);
            if (result)
            {
                return Ok(book);

            }
            return BadRequest();
        }
        [Route("api/book/delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            if (books.DeleteBook(id))
            {
                return Ok(books.GetAllBooks());
            }
            return NotFound();
        }

    }
}