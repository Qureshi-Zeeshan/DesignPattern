using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
   public interface IPizza
    {
        string description();
        double price();
        
    }
    class SimplePizza : IPizza
    {
        public string description() => "Simple Pizza";
        public double price() => 249;
        
    }

    public abstract class PizzaDecoration : IPizza
    {
        protected readonly IPizza _parent;
        protected PizzaDecoration (IPizza parent)
         {
            _parent = parent;
         }
        public virtual string description () =>  _parent.description();
        public virtual double price () => _parent.price();
    }
    public class Cheese : PizzaDecoration
    {
        internal Cheese (IPizza SimplePizza) : base (  SimplePizza)
        {
        }
        public override string description() => _parent.description() + " Extra Cheese";
        public override double price () => _parent.price() + 29;
    }
    public class Peporoni : PizzaDecoration
    {
        internal Peporoni(IPizza SimplePizza) : base(SimplePizza) { }
        public override string description() => _parent.description() + " With Peporoni";
        public override double price() => _parent.price() + 79;
    }
    public class Dips : PizzaDecoration
    {
        internal Dips(IPizza SimplePizza) : base(SimplePizza) { }
        public override string description() => _parent.description() + " With Dips";
        public override double price() => _parent.price() + 19;
    }
}
