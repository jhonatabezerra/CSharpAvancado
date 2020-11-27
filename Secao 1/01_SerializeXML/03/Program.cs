using System.IO;
using _00_Library;
using Nancy.Json;

namespace _03_SerializeJSON
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var user = new User() { Name = "Jhonata", CPF = "100.100.100-22", Email = "empresa@gmail.com" };

            var serializer = new JavaScriptSerializer();
            var stringObjSerializing = serializer.Serialize(user);

            var stream = new StreamWriter("C:\\Users\\jbezerra\\source\\repos\\01_SerializeJson.json");
            stream.WriteLine(stringObjSerializing);

            stream.Close();
        }
    }
}
