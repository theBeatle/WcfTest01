using System.Runtime.Serialization;

namespace WcfKnownTypes
{
    [DataContract]
    public class Yborschik : Worker
    {
        [DataMember]
        public bool IsMitlaOwner { get; set; }
        [DataMember]
        public int DlinaMitlu { get; set; }
    }

}
