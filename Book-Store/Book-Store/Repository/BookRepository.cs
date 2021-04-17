using Book_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.Repository
{
    public class BookRepository
    {
        public List<BookModels> GetAllBooks()
        {
            return DataSource();
        }
        public BookModels GetBookById(int Id)
        {
            return DataSource().Where(a => a.Id == Id).FirstOrDefault();
        }
        public List<BookModels> SearchBook(string Book_Title,string Author_Name)
        {
            return DataSource().Where(a => a.Title.Contains(Book_Title)&&a.Author.Contains(Author_Name)).ToList();
        }

        private List<BookModels> DataSource()
        {
            return new List<BookModels>()
            {
                new BookModels(){ Id=1,Title="mvc",Author="aravind" },
                new BookModels(){ Id=2,Title="java",Author="john" },
                new BookModels(){ Id=3,Title="php",Author="henry" },
                new BookModels(){ Id=4,Title="dotnet",Author="aravind" },

            };
        }
    }
}
