using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership_system
{
    class specs
    {
        public double price; //in $
    // all the dimensions in (inches)
        public double wheelbase;
        public double height;
        public double width; //without mirrors
        public double length;
    //engine && performance
        public string engine_type;
        public int cylinder;//number of cylinders in the engine
        public string horsepower;//(net@RPM)
    //(---------------------------------)
        public string transmission;
        public string fuel_type;
    //(---------------------------------)
        public specs() { }
        public string show_specs()
        {
        return "price= " + price + "$" + "\n" + "wheelbase= " + wheelbase + "in" + "\n" + "height= " + height +
               "in" + "\n" + "width= " + width + "in" + "\n" + "length= " + length + "in" + "\n" +
               "engine type= " + engine_type + "\n" + "engine cyliners= " + cylinder + " Cylinder Engine" +
               "\n" + "horsepower= " + horsepower + "\n" + "transmission= " + transmission + "\n" +
               "fuel type= " + fuel_type + "\n";


                
        }


    }
}
