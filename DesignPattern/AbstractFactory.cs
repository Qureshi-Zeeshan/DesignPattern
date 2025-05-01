using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    interface Icar
    {
        void car();
    }
    interface Ibike
    {
        void bike();
    }
    class HondaCar : Icar
    {
       public void car()
        {
            Console.WriteLine("This is honda car");
        }

    }
    class HondaBike : Ibike
    {
        public void bike()
        {
            Console.WriteLine("This is honda bike");
        }
    }
    class SuzukiCar : Icar
    {
       public void car()
        {
            Console.WriteLine("This is Suzuki car");
        }

    }
    class SuzukiBike : Ibike
    {
        public void bike()
        {
            Console.WriteLine("This is Suzuki bike");
        }
    }
    interface Get_Vehicle
    {
        Icar GetCar();
        Ibike GetBike();
    }
    class Honda : Get_Vehicle
    {
        public Ibike GetBike()
        {
            return new HondaBike();
        }

        public Icar GetCar()
        {
            return new HondaCar();
        }
    }
    class Suzuki : Get_Vehicle
    {
        public Ibike GetBike()
        {
            return new SuzukiBike();
        }

        public Icar GetCar()
        {
            return new SuzukiCar();
        }
    }

    internal class AbstractFactory
    {
    }
}
