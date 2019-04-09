using System.Runtime.Serialization;

namespace WcfServices
{ 
    [DataContract]
    public class Book
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{Id} {Title} {Author}";
        }
        public bool HasTheSameTitle(string newName)
        {

            return Title == newName;
        }

    }
}