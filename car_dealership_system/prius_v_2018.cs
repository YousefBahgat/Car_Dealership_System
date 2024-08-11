using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership_system
{
    class prius_v_2018 : toyotaa
    {
        private const double cost = 29850.50;
        private const double tax = 0.10;
      public prius_v_2018(int r,int b,int w):base(r,b,w)
        { 
        }
    public double calculate_tax()
    {
            double valuee = tax * cost;
            return valuee + cost;     
    }
    public override int Total_number_of_cars()
    {
        return base.Total_number_of_cars();
    }

    public override void purchase_red()
    {
        base.purchase_red();
    }

    public override void purchase_black()
    {
        base.purchase_black();
    }
    public override void purchase_white()
    {
        base.purchase_white();
    }
    public double remainder(double paid)
    {
        double remainderr;
        if (paid >= calculate_tax())
        {
                remainderr = paid - calculate_tax();
            return remainderr;
        }
        else return -1;
    }
        public string s2()
        {
        return "the total number of prius_v_2018 cars in the store is=" + Total_number_of_cars() + "\n" +
        "the total number of  prius_v_2018 cars with red color in the store is=" + red +
        "\n" + "the total number of  prius_v_2018 cars with black color in the store is=" + black +
        "\n" + "the total number of  prius_v_2018 cars with white color in the store is=" + white + "\n"
        + "--------------------------------------------------------------------------------------------" +
           "\n";
        }
     
    }
    }

