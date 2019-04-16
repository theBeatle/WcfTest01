using System.ServiceModel;

namespace WcfDuplecService
{
    [ServiceContract(CallbackContract = typeof(IServiceCallback))]
    public interface IService1
    {
        [OperationContract(IsOneWay = true)]
        void UselessFunction(int x);
    }

    public interface IServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void CallBackFunction(string message);
    }
}
