using System;
namespace AbstractFactoryDesignPattern
{
    class Program
    {
        public static void Main()
        {
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();
            IBike regularBike = regularVehicleFactory.CreateBike();

            regularBike.GetDetails();

            ICar regularCar = regularVehicleFactory.CreateCar();

            regularCar.GetDetails();

            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
            IBike sportsBike = sportsVehicleFactory.CreateBike();

            sportsBike.GetDetails();

            ICar sportsCar = sportsVehicleFactory.CreateCar();
            
            sportsCar.GetDetails();

            Console.ReadKey();
        }
    }
}