using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCVM.Models
{
    public class Book
    {
        public int id { get; set; }

        public string name { get; set; }
    }

    public class BookRepositry
    {
        public List<Book> GetAll()
        {
            List<Book> lst = new List<Book>
            {
                new Book {id = 1, name ="ASP.NET5 Web Forms"},
                new Book {id = 2, name ="ASP.NET5 MVC"}
            };

            return lst;
        }
    }
}