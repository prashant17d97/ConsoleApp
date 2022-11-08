using System;
using ConsoleApp.Model;
using ConsoleApp.Service.WebApp;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = HttpHelper.GetList<Comments>("posts").Result;

            /*Console.WriteLine(items.Id);
            Console.WriteLine(items.Body);
            Console.WriteLine(items.UserId);
            Console.WriteLine(items.Title);*/
            foreach (var items in data)
            {
                Console.WriteLine("Id: " + items.Id+",");
                Console.WriteLine("Body: " + items.Body + ",");
                Console.WriteLine("UserId: " + items.UserId + ",");
                Console.WriteLine("Title: " + items.Title + ",\n\n\n");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
