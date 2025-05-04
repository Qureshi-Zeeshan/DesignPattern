using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Prototype
    {
       internal string Data {  get; set; }
        internal string IPAddress {  get; set; }

        public Prototype Clone()
        {
            return new Prototype()
            {
                Data = this.Data,
                IPAddress = this.IPAddress
            };
            
        }

        public void SeeInfo()
        {
            Console.WriteLine($"The Data is {Data} and Ip Address is {IPAddress}");
        }
        
    }
}
