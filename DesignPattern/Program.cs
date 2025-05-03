using System;
using DesignPattern;
namespace DesignPattern
{
    class DesignProgram
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

            lazyloading ll = lazyloading.Instance;
            Console.WriteLine(ll);

            Console.WriteLine();
            Console.WriteLine();

            Builder builder = new Builder();
            Make_Vehicle make_vehicle = builder.Set_Type("Sedan").Build();
            Console.WriteLine(make_vehicle.AWD);


        }
    }
}