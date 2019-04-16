using ClientSoftServ.SoftServeNS;
using System;
using System.Linq;
using System.ServiceModel;

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

            try
            {
                client.ExceptionGenerator();
            }
            catch (FaultException<MyWcfSuperPuperException> err)
            {
                Console.WriteLine($"M - {err.Message}\nR - {err.Reason}\nS - {err.Source}");
                Console.WriteLine($"M - {err.Detail.Message}\nR - {err.Detail.Result}\nS - {err.Detail.Description}");
            }
            catch (FaultException fe)
            {
                Console.WriteLine($"Halepa - {fe}");
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine("Htos ne vudiluv pamjati");
            }
            catch (Exception)
            {
                Console.WriteLine("Useless block");
                
            }


            

            Console.WriteLine(new String('-', 20));
            Console.WriteLine(new String('-', 20));

            try
            {
                Console.WriteLine(client.GetWorkersQuantityByName("Stepanuch"));
               
            }
            catch (FaultException<NameAbsenceFault> err)
            {
                Console.WriteLine($"M - {err.Message}\nR - {err.Reason}\nS - {err.Source}");
                Console.WriteLine($"M - {err.Detail.Message}\nR - {err.Detail.Result}\nS - {err.Detail.Description}");
            }
            



            client.Close();
        }
    }
}
