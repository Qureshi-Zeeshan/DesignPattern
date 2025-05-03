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
    internal class ReadyMadeVehicle
    {
        Builder makingvehichle;
        public ReadyMadeVehicle(Builder MakeVehicle)
        {
            makingvehichle = MakeVehicle;
        }
        public Builder MakeSuv()
        {
            makingvehichle.Set_AWD()
                .Set_Ice()
                .Set_Brand("Toyota");
            return makingvehichle;
        }
        public Builder MakeElectric()
        {
            makingvehichle.Set_Electric().Set_AWD().Set_Brand("BYD");
            return makingvehichle;
        }
    }
}
