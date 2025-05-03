using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Make_Vehicle
    {
        public string Type;
        public bool AWD;
        public bool ICE;
        public bool Electric;
        public string brand;

    }
    internal class Builder
    {
       private Make_Vehicle MV =new Make_Vehicle();

        public Builder Set_Type (string TypeOfVehichle)
        {
            MV.Type = TypeOfVehichle;
            return this;
        }
        public Builder Set_AWD()
        {
            MV.AWD = true;
            return this;
        }
        public Builder Set_Ice()
        {
            MV.ICE = true;
            return this;
        }
        public Builder Set_Electric()
        {
            MV.Electric = true;
            return this;
        }
        public Builder Set_Brand(string BrandName)
        {
            MV.brand = BrandName;
            return this;
        }
        public Make_Vehicle Build() => MV;
    }
}
