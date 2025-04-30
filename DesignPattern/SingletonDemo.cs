using System;

namespace DesignPattern
{
    internal sealed class SingletonDemo
    {
        private static SingletonDemo sinstance;

        private SingletonDemo() { }

        public static SingletonDemo get_singleton()
        {
            if(sinstance == null)
            {
                sinstance = new SingletonDemo();
            }
            return sinstance;
        }

    }
}
