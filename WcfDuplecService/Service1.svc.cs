using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDuplecService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Service1 : IService1
    {
        List<Data> dataBase = new List<Data>();
        IServiceCallback cb = OperationContext.Current.GetCallbackChannel<IServiceCallback>();
        public void UselessFunction(int x)
        {
            dataBase.Add(new Data { Value = x, Time = DateTime.Now });
            var lastValue = dataBase.Last();
            cb.CallBackFunction($"Hello from CallBack <{lastValue.Value}> {lastValue.Time}");
        }
    }

    public class Data
    {
        public int Value { get; set; }
        public DateTime Time { get; set; }
    }
}
