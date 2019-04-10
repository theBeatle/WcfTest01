using System.Runtime.Serialization;

namespace WcfKnownTypes
{
    [DataContract]
    public class Swarschik : Worker
    {
        [DataMember]
        public bool HasSwarka { get; set; }
        [DataMember]
        public int ElektrodQuantity { get; set; }
    }

}
