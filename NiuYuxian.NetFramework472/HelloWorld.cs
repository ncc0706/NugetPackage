using System;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace NiuYuxian.NetFramework472
{
    public class HelloWorld
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello nuget .net framework4.7.2");
            var md5 = MD5.Create();
            var password = "abc123";
            var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            password = BitConverter.ToString(bytes);
            var user = new User
            {
                Password = password,
                Username = "admin",
                Age = 10
            };
            var jsonData = JsonConvert.SerializeObject(user, Formatting.Indented);
            Console.WriteLine(jsonData);
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}