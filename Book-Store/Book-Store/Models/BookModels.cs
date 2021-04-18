using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.Models
{
    public class BookModels
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string  Category { get; set; }
        public string Language { get; set; }    
        public int NumberOfPages { get; set; }
    }
}
