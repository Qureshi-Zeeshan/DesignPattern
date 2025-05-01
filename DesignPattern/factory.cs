using System;


namespace DesignPattern
{
    interface Vehicle_Info
    {
        void seater();
        void milage();
    }
    internal class Car : Vehicle_Info
    {
       public void seater()
       {
            Console.WriteLine("Car is 4 seater");
       }
        
        public void milage()
        {
            Console.WriteLine("mileage of car is 24 kmpl");
        }

    }
    class Bike : Vehicle_Info
    {
        public void seater()
        {
            Console.WriteLine("bike is 2 seater");
        }

        public void milage()
        {
            Console.WriteLine("mileage of bike is 64 kmpl");
        }

    }
    internal class factory
    {
        public static Vehicle_Info vehicle_factory(string vehicle_name)
        {
            if (vehicle_name.ToLower().Equals("bike"))
            {
                return new Bike();
            }
            else if (vehicle_name.ToLower().Equals("car"))
            {
                return new Car();
            }
            else return null;
        }
    }

}
