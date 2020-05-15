using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Learn.BookStore.Models;
using Learn.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Learn.BookStore
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookrepository = null;

        public BookController()
        {
            _bookrepository = new BookRepository();
        }
        public List<BookModel> GetAllBooks()
        {
            return _bookrepository.GetAllBooks();
        }

        public BookModel GetBook(int id)
        {
            return _bookrepository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string name, string author)
        {
            return _bookrepository.SearchBook(name, author);
        }
    }
}