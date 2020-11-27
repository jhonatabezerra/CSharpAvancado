using System;
using System.IO;
using System.Xml.Serialization;
using _00_Library;

namespace _02_Deserialize
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Path to Reader to xml after serializing
            var stream = new StreamReader("C:\\Users\\jbezerra\\source\\repos\\01_SerializeXml.xml");

            var serializer = new XmlSerializer(typeof(User));

            var user = (User)serializer.Deserialize(stream);

            Console.WriteLine("User:{0}\nCPF:{1}\nEmail:{2}\n", user.Name, user.CPF, user.Email);
            Console.ReadKey();
        }
    }
}
