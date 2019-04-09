using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClientTest01.ServiceReference;

namespace WcfClientTest01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Service1Client client = new Service1Client();
            Console.WriteLine(client.HelloResponse("Burt Simpson"));
            Console.WriteLine(client.SimpleCalculator( 24m, 56.7m, '*'));
            Console.WriteLine(client.GetBookById(1).Id);
            Console.WriteLine(client.GetBookById(1).Author);
            Console.WriteLine(client.GetBookById(1).Title);

            client.AddNewBook(new Book { Id = 10, Author = "newBook", Title = "newAuthor" });
            Console.WriteLine(client.GetBookById(10)?.Title);

            client.Close();
        }
    }
}
