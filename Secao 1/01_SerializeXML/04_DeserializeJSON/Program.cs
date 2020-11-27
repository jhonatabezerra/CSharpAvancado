using System;
using System.IO;
using _00_Library;
using Nancy.Json;

namespace _04_DeserializeJSON
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stream = new StreamReader("C:\\Users\\jbezerra\\source\\repos\\01_SerializeJson.json");
            var fileLines = stream.ReadToEnd();
            var serializer = new JavaScriptSerializer();
            var user = serializer.Deserialize<User>(fileLines);

            Console.WriteLine("Name: {0}\nCPF: {1}\nEmail: {2}\n", user.Name, user.CPF, user.Email);
            Console.ReadKey();
        }
    }
}
