using System;
using System.Runtime.Serialization;

namespace WcfKnownTypes
{
    [Serializable]
    public class NameAbsenceException : Exception
    {
        public NameAbsenceException()
        {
        }

        public NameAbsenceException(string message) : base(message)
        {
        }
    }

    [DataContract]
    public class NameAbsenceFault
    {
        [DataMember]
        public bool Result { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}