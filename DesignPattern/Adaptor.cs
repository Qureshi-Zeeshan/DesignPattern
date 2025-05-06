using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    interface ITarget
    {
        string ElectricEngineType();
    }
    class PetrolCar    //adaptee
    {
       public string EngineType()
       {
            return "Petrol";
       }
    }
    class DieselCar    //adaptee
    {
        public string EngineType()
        {
            return "Diesel";
        }
    }
    internal class Adaptor : ITarget
    {
        private object _target;
        public Adaptor(object target)
        {
            _target = target;
        }
        public string ElectricEngineType()
        {
            if (_target is PetrolCar petrolcar)
            {
                return petrolcar.EngineType();
            }
            else if (_target is DieselCar dieselcar)
            {
               return dieselcar.EngineType();
            }
            else
            {
                return "Electricity Motor";
            }
        }
    }
}
