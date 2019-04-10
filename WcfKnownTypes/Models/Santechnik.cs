using System.Runtime.Serialization;

namespace WcfKnownTypes
{
    [DataContract]
    public class Santechnik : Worker
    {
        [DataMember]
        public bool IsVantuzOwner { get; set; }
        [DataMember]
        public bool IsRazvodnujKeyOwner { get; set; }
    }

}
