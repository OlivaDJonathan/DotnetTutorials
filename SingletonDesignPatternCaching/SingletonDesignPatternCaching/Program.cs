using System;
namespace SingletonDesignPatternCaching
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonCache cache = SingletonCache.GetInstance();

            Console.WriteLine("Adding Keys and Values into Cache");
            Console.WriteLine($" Adding Id in Cache: {cache.Add("Id", 1001)}");
            Console.WriteLine($" Adding Name in Cache: {cache.Add("Name", "Pranaya")}");
            Console.WriteLine($" Adding Same Id Key in Cache using Add: {cache.Add("Id", 2001)}");
            Console.WriteLine($" Adding Same Id Key in Cache using AddOrUpdate: {cache.AddOrUpdate("Id", 2001)}");

            Console.WriteLine("\nFetching Values from Cache");
            Console.WriteLine($" Fetching Id From Cache: {cache.Get("Id")}");
            Console.WriteLine($" Fetching Name From Cache: {cache.Get("Name")}");

            Console.WriteLine("\nRemoving Values from Cache");
            Console.WriteLine($" Remove Id: {cache.Remove("Id")}");
            Console.WriteLine($" Accessing Id From Cache: {cache.Get("Id")}");

            cache.Clear();
            Console.WriteLine("\nClearing All Keys and Values");
            Console.WriteLine($"Fetching Name From Cache: {cache.Get("Name")}");
            Console.ReadKey();
        }
    }
}
