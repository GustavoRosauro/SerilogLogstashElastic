using System;
using System.Threading;
using Serilog;

namespace SeriLogExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
            .WriteTo.Http("http://localhost:8080")
            .CreateLogger();
            for(int i = 0;i < 1000;i++)
            {
                string json = $"Numero: {i+1}, Indice: {i}";
                log.Information("{"+json+"} registred");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
