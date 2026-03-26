using System;
namespace FluentInterfaceDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee obj = new FluentEmployee();

            obj.NameOfTheEmployee("Anurag Mohanty")
                    .Born("10/10/1992")
                    .WorkingOn("IT")
                    .StaysAt("Mumbai-India");
            obj.ShowDetails();

            Console.Read();

            var order = new ShoppingCartBuilder()
            .AddProduct("Laptop", 1000m)
            .AddProduct("Mouse", 50m)
            .RemoveProduct("Mouse")
            .AddProduct("Keyboard", 70m)
            .Checkout();

            Console.WriteLine($"Total Price: {order.TotalPrice}");
            Console.ReadKey();
        }
    }
}