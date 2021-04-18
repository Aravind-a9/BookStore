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
                new BookModels(){ Id=1,Title="mvc",Author="aravind",Description="Here is the best tutotials for MVC pratice",Category="MVC",Language="English",NumberOfPages=765 },
                new BookModels(){ Id=2,Title="java",Author="john",Description="Java is one of the best things to be learnt as a developer",Category="Programming",Language="English",NumberOfPages=467 },
                new BookModels(){ Id=3,Title="php",Author="henry",Description="php is for server side scripting language for better perfomances",Category="Server Side",Language="English",NumberOfPages=879 },
                new BookModels(){ Id=4,Title="dotnet",Author="aravind",Description="dotnet is one of the grate platforms for development",Category="Development",Language="English",NumberOfPages=230 },

            };
        }
    }
}
