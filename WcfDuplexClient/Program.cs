using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfDuplexClient.CallbackNS;

namespace WcfDuplexClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ClientCallback cc = new ClientCallback())
            {
                for (int i = 0; i < 10; i++)
                {
                    cc.CallService(i);
                }
                Console.Read();
            }
            //cc.Dispose()

        }
    }

    class ClientCallback : IService1Callback, IDisposable
    {
        Service1Client client;
        public void CallBackFunction(string message)
        {
            Console.WriteLine($"Msg fromServer = {message}");
        }

        public void CallService(int y)
        {
            InstanceContext ic = new InstanceContext(this);
            client = new Service1Client(ic);
            client.UselessFunction(y);
        }

        public void Dispose()
        {
            client.Close();
        }
    }
}
