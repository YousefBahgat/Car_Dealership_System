using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_dealership_system
{
    public partial class Form2 : Form
    {
        toyotaa systemm = new toyotaa(16, 15, 19);
        prius_v_2018 c1 = new prius_v_2018(5, 4, 6);
        Corolla_xle_2018 c2 = new Corolla_xle_2018(4, 5, 8);
        landcruiser_2018 c3 = new landcruiser_2018(7, 6, 5);
        int flag = 0;
        string modell_name;
        public int  counter_red;
        public int counter_black;
        public int counter_white;
        public int counter_red1;
        public int counter_black1;
        public int counter_white1;
        public int counter_red2;
        public int counter_black2;
        public int counter_white2;
        public int counter_red3;
        public int counter_black3;
        public int counter_white3;
        public string x;
        public Form2(string x,int counter_red,int counter_black,int counter_white,int counter_red1,int counter_black1,int counter_white1, int counter_red2, int counter_black2, int counter_white2, int counter_red3, int counter_black3, int counter_white3)
        {
            InitializeComponent();
            this.x = x;
            this.counter_black = counter_black;
            this.counter_red = counter_red;
            this.counter_white = counter_white;
            this.counter_black1 = counter_black1;
            this.counter_red1 = counter_red1;
            this.counter_white1 = counter_white1;
            this.counter_black2 = counter_black2;
            this.counter_red2= counter_red2;
            this.counter_white2 = counter_white2;
            this.counter_black3 = counter_black3;
            this.counter_red3 = counter_red3;
            this.counter_white3 = counter_white3;
        }
     
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x== "red")
            {
                
                    systemm.red = systemm.red - counter_red;
                    c1.red = c1.red - counter_red1;
                    c1.purchase_red();
                    systemm.purchase_red();
                   
                
                MessageBox.Show(systemm.s1() + c1.s2()+c2.s3()+c3.s4());
            }
            else if(x== "black")
            {
                if (flag == 0)
                {
                    systemm.black = systemm.black- counter_black;
                    c1.black = c1.black - counter_black1;
                    c1.purchase_black();
                    systemm.purchase_black();
                    flag = 1;
                }
                MessageBox.Show(systemm.s1() + c1.s2()+c2.s3()+c3.s4());
            }
            else if(x== "white")
            {
                if (flag == 0)
                {
                    systemm.white = systemm.white - counter_white;
                    c1.white = c1.white - counter_white1;
                    c1.purchase_white();
                    systemm.purchase_white();
                    flag = 1;
                }
                MessageBox.Show(systemm.s1() + c1.s2()+c2.s3()+c3.s4());
            }
            else if(x=="red1")
            {
                if (flag == 0)
                {
                    systemm.red = systemm.red - counter_red;
                    c2.red = c2.red - counter_red2;
                    c2.purchase_red();
                    systemm.purchase_red();
                    flag = 1;
                }
                MessageBox.Show(systemm.s1() + c1.s2() + c2.s3() + c3.s4());
            }
            else if (x == "black1")
            {
                if (flag == 0)
                {
                    systemm.black = systemm.black - counter_black;
                    c2.black = c2.black - counter_black2;
                    c2.purchase_black();
                    systemm.purchase_black();
                    flag = 1;
                }
                MessageBox.Show(systemm.s1() + c1.s2() + c2.s3() + c3.s4());
            }
            else if (x == "white1")
            {
                if (flag == 0)
                {
                    systemm.white = systemm.white - counter_white;
                    c2.white = c2.white - counter_white2;
                    c2.purchase_white();
                    systemm.purchase_white();
                    flag = 1;
                }
                MessageBox.Show(systemm.s1() + c1.s2() + c2.s3() + c3.s4());
            }
            else if (x == "red2")
            {
                if (flag == 0)
                {
                    systemm.red = systemm.red - counter_red;
                    c3.red = c3.red - counter_red3;
                    c3.purchase_red();
                    systemm.purchase_red();
                    flag = 1;
                }
                MessageBox.Show(systemm.s1() + c1.s2() + c2.s3() + c3.s4());
            }
            else if (x == "black2")
            {
                if (flag == 0)
                {
                    systemm.black = systemm.black - counter_black;
                    c3.black = c3.black - counter_black3;
                    c3.purchase_black();
                    systemm.purchase_black();
                    flag = 1;
                }
                MessageBox.Show(systemm.s1() + c1.s2() + c2.s3() + c3.s4());
            }
            else if (x == "white2")
            {
                if (flag == 0)
                {
                    systemm.white = systemm.white - counter_white;
                    c3.white = c3.white - counter_white3;
                    c3.purchase_white();
                    systemm.purchase_white();
                    flag = 1;
                }
                MessageBox.Show(systemm.s1() + c1.s2() + c2.s3() + c3.s4());
            }
            else if (x == "")
            {
                MessageBox.Show(systemm.s1() + c1.s2()+c2.s3()+c3.s4());
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            modell_name = cb1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            //general features of prius_v_2018
            c1.general_specs.price = 29850.50;
            c1.general_specs.wheelbase = 109.4;
            c1.general_specs.height = 62;
            c1.general_specs.width = 69.9;
            c1.general_specs.length = 182.3;
            c1.general_specs.engine_type = "Gas/electric I-4";
            c1.general_specs.cylinder = 4;
            c1.general_specs.horsepower = "134@5200";
            c1.general_specs.transmission = "Automatic-CVT"; //continuously variable trans
            c1.general_specs.fuel_type = "hybrid fuel";
            //general features of corolla_xle_2018
            c2.general_specs.price = 18600;
            c2.general_specs.wheelbase = 106.3;
            c2.general_specs.height = 57.3;
            c2.general_specs.width = 69.9;
            c2.general_specs.length = 183.1;
            c2.general_specs.engine_type = "Regular Unleaded I-4";
            c2.general_specs.cylinder = 4;
            c2.general_specs.horsepower = "132@6000";
            c2.general_specs.transmission = "Automatic-CVT"; //continuously variable trans
            c2.general_specs.fuel_type = "Gasoline fuel";
            //general features of landcruiser_2018
            c3.general_specs.price = 84565.00;
            c3.general_specs.wheelbase = 112.2;
            c3.general_specs.height = 74;
            c3.general_specs.width = 78;
            c3.general_specs.length = 194.90;
            c3.general_specs.engine_type = "Regular Unleaded V-8";
            c3.general_specs.cylinder = 8;
            c3.general_specs.horsepower = "381@5600";
            c3.general_specs.transmission = "Automatic with manual mode"; 
            c3.general_specs.fuel_type = "Gasoline fuel";
            //(-----------------------------------------------------------)
            if(modell_name=="prius_v_2018")
            {
                MessageBox.Show(c1.general_specs.show_specs());
            }
            else if(modell_name == "corolla_xle_2018")
            {
                MessageBox.Show(c2.general_specs.show_specs());
            }
            else if(modell_name == "landcruiser_2018")
            {
                MessageBox.Show(c3.general_specs.show_specs());
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
