using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string HelloResponse(string name);

        [OperationContract]
        decimal SimpleCalculator(decimal a, decimal b, char @operator);

        [OperationContract]
        Book GetBookById(int id);

        [OperationContract]
        bool AddNewBook(Book book);

      
    }
}
