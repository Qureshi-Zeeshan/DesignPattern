using System;

namespace DesignPattern
{
    internal sealed class SingletonDemo
    {
        private static SingletonDemo sinstance;

        private SingletonDemo() { }

        private static object obj=new object();

        public static SingletonDemo get_singleton()
        {
            lock (obj)
            {
            if(sinstance == null)
            {
                sinstance = new SingletonDemo();
            }

            }
            return sinstance;
        }

    }
    internal sealed class lazyloading
    {
        private static readonly Lazy<lazyloading> instance=new Lazy<lazyloading>(() => new lazyloading());
        private lazyloading() { }
        public static lazyloading Instance => instance.Value;
    }
}
