using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership_system
{
    class toyotaa
    {
        private const double tax = 0.0;
        private const double cost = 0.0;
        public int red;//the number of cars with red color
        public int black;//the number of cars with black color
        public int white;//the number of cars with white color
        public specs general_specs = new specs();
     public toyotaa(int red ,int black,int white)
        {
            this.red = red;
            this.black = black;
            this.white = white;

        }
        private double calculate_tax()
        {
            double valuee = tax * cost;
            return valuee + cost;
        }
        public virtual int Total_number_of_cars()
        {
            return red + black + white;

        }
        public virtual void purchase_red()
        {
            red -= 1;

        }
        public virtual void purchase_black()
        {
            black -= 1;
        }
        public virtual void purchase_white()
        {
            white -= 1;
        }
        public string s1()
        {
         return "the total number of cars in the store is= " + Total_number_of_cars() + "\n" +
                "the total number of red cars in the store is= " + red + "\n" +
                "the total number of black cars in the store is= " + black + "\n" +
               "the total number of white cars in the store is= " + white + "\n" +
        "--------------------------------------------------------------------------------------------" +
            "\n";

        }

  
    }
}
