using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership_system
{
    class landcruiser_2018:toyotaa
    {
        private const double cost = 84565.00;
        private const double tax = 0.20;
        public landcruiser_2018(int r,int b,int w):base(r,b,w)
        {
        }
        public double calculate_tax3()
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
        public double remainder3(double paid)
        {
            double remainderr;
            if (paid >= calculate_tax3())
            {
                remainderr = paid - calculate_tax3(); 
                return remainderr;
            }
            else
                return -1;
        }
        public string s4()
        {
            return "the total number of landcruiser_2018 cars = " + Total_number_of_cars() +
            "\n" + "the total number of landcruiser_2018 cars with red color = " + red +
            "\n" + "the total number of landcriuser_2018 cars with black color = " + black +
            "\n" + "the total number of landcriuser_2018 cars with white color = " + white +
            "\n" +
            "--------------------------------------------------------------------------------------------"
             + "\n";

        }
    }
}
