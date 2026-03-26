using System;
namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PDFReport pdfReport = new PDFReport();
            ReportDirector reportDirector = new ReportDirector();
            Report report = reportDirector.MakeReport(pdfReport);

            report.DisplayReport();

            Console.WriteLine("-------------------");
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            
            report.DisplayReport();

            Console.ReadKey();

            Beverage beverage;
            BeverageDirector beverageDirector = new BeverageDirector();
            
            TeaBuider tea = new TeaBuider();
            beverage = beverageDirector.MakeBeverage(tea);

            Console.WriteLine(beverage.ShowBeverage());

            CoffeeBuilder coffee = new CoffeeBuilder();
            beverage = beverageDirector.MakeBeverage(coffee);
            
            Console.WriteLine(beverage.ShowBeverage());
            Console.ReadKey();
        }
    }
}