using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "BookWar", Author = "Narod" },
            new Book { Id = 2, Title = "Vtoraja" , Author = "Useless" },
            new Book { Id = 3, Title = "Siniaja",  Author = "Nameless"  }

        };

        public bool AddNewBook(Book book)
        {
            int oldLength = books.Count;
            books.Add(book);
            int newLength = books.Count;
            return newLength > oldLength;
        }

        public Book GetBookById(int id)
        {
            return books.SingleOrDefault(b => b.Id == id);
        }

        public string HelloResponse(string name)
        {
            return $"Hello from Hell, {name}! ";
        }

        public decimal SimpleCalculator(decimal a, decimal b, char @operator)
        {
            return a * b;
        }
    }
}
