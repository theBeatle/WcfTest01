using System.Runtime.Serialization;

namespace WcfKnownTypes
{
    [DataContract]
    [KnownType(typeof(Swarschik))]
    [KnownType(typeof(Yborschik))]
    [KnownType(typeof(Santechnik))]
    public abstract class Worker
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal Salary { get; set; }
    }

}
