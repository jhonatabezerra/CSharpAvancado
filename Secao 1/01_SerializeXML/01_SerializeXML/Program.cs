using System.IO;
using System.Xml.Serialization;
using _00_Library;

namespace _01_SerializeXML
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var user = new User() {Name = "Jhonata", CPF = "100.100.100-22", Email = "jhonata@gmail.com"};

            //Get object type
            var serializer = new XmlSerializer(typeof(User)); //Or use (user.GetType());

            //Path to writer to xml after serializing
            var stream = new StreamWriter("C:\\Users\\jbezerra\\source\\repos\\01_SerializeXml.xml");

            serializer.Serialize(stream, user);
        }
    }
}
