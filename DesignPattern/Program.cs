using System;
namespace DesignPattern
{
    class DesignPattern
    {
        public static void Main(string[] args)
        {
            SingletonDemo obj =  SingletonDemo.get_singleton();
            SingletonDemo obj1 = SingletonDemo.get_singleton();

        }
    }
}