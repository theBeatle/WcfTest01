using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfKnownTypes
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int GetWorkersQuantity();

        [OperationContract]
        string GetRichestWorkerName();

        [OperationContract]
        decimal GetHighestSalary();

        [OperationContract]
        int GetWorkersQuantityByName(string name);

        [OperationContract]
        Swarschik[] GetTop3SwarschiksBySalary();

        [OperationContract]
        Worker[] GetTop5WorkersBySalary();

        [OperationContract]
        void ExceptionGenerator();


    }
}
