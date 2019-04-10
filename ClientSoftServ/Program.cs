using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientSoftServ.SoftServeNS;



namespace ClientSoftServ
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();

            Console.WriteLine(client.GetHighestSalary());
            Console.WriteLine(new String('-', 20));
            Console.WriteLine(client.GetRichestWorkerName());
            Console.WriteLine(new String('-',20));
            client.GetTop3SwarschiksBySalary()
                .ToList()
                .ForEach(s => Console.WriteLine($" {s.Id} {s.Name} {s.Salary}"));
            Console.WriteLine(new String('-', 20));
            client.GetTop5WorkersBySalary()
                .ToList()
                .ForEach(s => Console.WriteLine($" {s.Id} {s.Name} {s.Salary}"));
            Console.WriteLine(new String('-', 20));
            Console.WriteLine(client.GetWorkersQuantity());
            Console.WriteLine(new String('-', 20));
            Console.WriteLine(client.GetWorkersQuantityByName("Ivan"));
            Console.WriteLine(new String('-', 20));


            client.ExceptionGenerator();

            client.Close();
        }
    }
}
