using System;
using DesignPattern;
namespace DesignPattern
{
    class DesignProgram
    {
        public static void Main(string[] args)
        {
            SingletonDemo obj = SingletonDemo.get_singleton();
            SingletonDemo obj1 = SingletonDemo.get_singleton();

            Vehicle_Info bike = factory.vehicle_factory("bike");
            bike.seater();
            bike.milage();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Get_Vehicle honda = new Honda();
            Ibike honda_bike = honda.GetBike();
            honda_bike.bike();

            lazyloading ll = lazyloading.Instance;
            Console.WriteLine(ll);

            Console.WriteLine();
            Console.WriteLine();

            Builder builder = new Builder();
            Make_Vehicle make_vehicle = builder.Set_Type("Sedan").Build();
            Console.WriteLine(make_vehicle.AWD);

            Builder suvbuilder = new Builder();
            ReadyMadeVehicle MakingSuv = new ReadyMadeVehicle(suvbuilder);
            Make_Vehicle Suv = MakingSuv.MakeSuv().Build();

            Console.WriteLine();
            Console.WriteLine();

            IPizza pizza = new SimplePizza();
            Console.WriteLine(pizza.description() + " " + pizza.price());
            pizza = new Cheese(pizza);
            pizza = new Peporoni(pizza);
            Console.WriteLine(pizza.description() + " " + pizza.price());

            Console.WriteLine();
            Console.WriteLine();

            Prototype prototype = new Prototype();
            prototype.IPAddress = "234.456.345";
            prototype.Data = "Very Expensive data";

            Prototype clonePrototype = prototype.Clone();
            clonePrototype.SeeInfo();

            Console.WriteLine();
            Console.WriteLine();

            Subject cSharp = new Subject();
            Observers Zeeshan = new Observers("Zeeshan");
            cSharp.Attach(Zeeshan);
            cSharp.NewContent("Concurrency");
            Console.WriteLine(cSharp.ShowObservers());

            Console.WriteLine();
            Console.WriteLine();

            Subject2 subject2 = new Subject2();
            IObserver2 Device1 = new Observer2("Device1");
            IObserver2 Device2 = new Observer2("Device2");
            IObserver2 Device3 = new Observer2("Device3");
            subject2.Attach(Device1);
            subject2.Attach(Device2);
            subject2.Attach(Device3);

            subject2.SetTemperature("50 degree");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Aggregate Library =new Aggregate();
            Iterator iterate = new Iterator(Library);
            Library.AddBook("Harry Potter");
            Library.AddBook("The song of Ice and fierce");
            Console.WriteLine(iterate.Next()+ "\n" +Library.TotalBooks() );


        }
    }
}