using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirtySkunk.Core.Models;
using DirtySkunk.Core.Exceptions;

namespace DirtySkunk.Core.Services
{
    public class BookService : IBookService
    {
        private static BookService _instance = null;
        private List<Book> _books;

        private BookService()
        {
            _books = new List<Book>()
            {
                new Book("Toto", "Tata", "Synopsis", DateTime.Now, 2),
                new Book("Toto", "Tata", "Synopsis", DateTime.Now, 2)
            };
        }

        public static BookService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BookService();
            }
            return _instance;
        }

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public List<Book> Books()
        {
            return _books;
        }

        public List<Book> BooksSortedByParutionDate()
        {
            return _books.OrderBy(book => book.ParutionDate).ToList();
        }

        public Book GetBookByGuid(string id)
        {
            foreach (Book book in _books)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }

            throw new BookNotFoundException(id);
        }

        public void Remove(string id)
        {
            foreach (Book book in _books)
            {
                if (book.Id == id)
                {
                    _books.Remove(book);
                }
            }
        }
    }
}
