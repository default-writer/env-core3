using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace env_core3
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .AddEnvironmentVariables();
            var value = Environment.GetEnvironmentVariable("TestKey");
            Console.WriteLine("Hello World!");
        }
    }
}
