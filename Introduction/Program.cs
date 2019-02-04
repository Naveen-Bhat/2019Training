using System;
using Lib1;
using Lib2;
using Newtonsoft.Json;

namespace Introduction
{
    // Client ->[http] -> TCP, UDP(DSN Lookup)  Server
    // Browser ->[http] -> IIS -> Asp.Net (MVC)

    // Asp.Net MVC 6
    // Rzor, Action Filters, Controllers, Views, Models,
    // Routing, Middlewares
    // Host

    // MS-SQL Server (Database)

    public class Program
    {
        public static void Main(string[] args)
        {
            var a = new A()
            {
                Id = 10,
                Name = "Naveen"
            };

            Console.ReadKey();
        }
    }
}
