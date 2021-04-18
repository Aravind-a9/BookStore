using Book_Store.Models;
using Book_Store.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookreRository;

        public BookController()
        {
            _bookreRository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            var data = _bookreRository.GetAllBooks();

            return View(data);
        }

        public ViewResult GetBookById(int Id)
        {
            var data = _bookreRository.GetBookById(Id);
            return View(data);

        }

        public List<BookModels> SearchBooks(string Book_Title,string Author_Name)
        {
            return _bookreRository.SearchBook(Book_Title, Author_Name);
        }
    }
}
