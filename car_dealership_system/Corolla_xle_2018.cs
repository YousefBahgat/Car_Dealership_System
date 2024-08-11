using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership_system
{
    class Corolla_xle_2018:toyotaa
    {
        private const double cost = 18600.00;
        private const double tax = 0.15;
        public Corolla_xle_2018(int r, int b, int w):base(r,b,w)
        { }
        public double calculate_tax2()
        {
            double valuee = cost * tax;
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
        public double remainder2(double paid)
        {
            double remainderr;
            if (paid >= calculate_tax2())
            {
                remainderr = paid - calculate_tax2();
                return remainderr;
            }
            else
                return -1;
        }
        public string s3()
        {
        return "the total number of corolla_xle_2018 cars = " + Total_number_of_cars() +
        "\n" + "the total number of corolla_xle_2018 cars with red color = " + red +
        "\n" + "the total number of corolla_xle_2018 cars with black color = " + black +
        "\n" + "the total number of corolla_xle_2018 cars with white color = " + white +
        "\n" +
        "--------------------------------------------------------------------------------------------"
         + "\n";

        }
        
    }
}
