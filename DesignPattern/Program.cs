using System;
namespace DesignPattern
{
    class DesignPattern
    {
        public static void Main(string[] args)
        {
            SingletonDemo obj =  SingletonDemo.get_singleton();
            SingletonDemo obj1 = SingletonDemo.get_singleton();

            Vehicle_Info bike = factory.vehicle_factory("bike");
            bike.seater();
            bike.milage();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Get_Vehicle honda = new Honda();
            Ibike honda_bike =honda.GetBike();
            honda_bike.bike();

        }
    }
}