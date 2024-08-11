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
    
    public partial class Form1 : Form
    {
        toyotaa systemm = new toyotaa(16,15,19);// total number of cars is assumed 50.
        prius_v_2018 c1= new prius_v_2018(5,4,6);
        Corolla_xle_2018 c2 = new Corolla_xle_2018(4, 5, 8);
        landcruiser_2018 c3 = new landcruiser_2018(7, 6, 5);
        Form2 f = new Form2("empty",-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1);
        string model_name;
        double remainderr;
        double costt;
        string temp = " ";
        int flag = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            model_name = textBox1.Text;
        }
        private void t2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (model_name == "prius_v_2018" && (rb1.Checked || rb2.Checked || rb3.Checked))
            {
                flag = 1;
                costt = c1.calculate_tax();
                remainderr = c1.remainder(Convert.ToDouble(t2.Text));
                temp = "cost without tax= 29850.50$" + "\n" +
                "the total cost with tax= " + costt + "$" + "\n" + "the paid value= " + t2.Text + "$" + "\n" +
                "the remainder= " + remainderr + "$";
            }
            else if (model_name == "corolla_xle_2018" && (rb1.Checked || rb2.Checked || rb3.Checked))
            {
                flag = 1;
                costt = c2.calculate_tax2();
                remainderr = c2.remainder2(Convert.ToDouble(t2.Text));
                temp = "cost without tax= 18600.00$" + "\n" +
                "the total cost with tax=" + costt + "$" + "\n" + "the paid value=" + t2.Text + "$" + "\n" +
                "the remainder= " + remainderr + "$";
            }
            else if (model_name == "landcruiser_2018" && (rb1.Checked || rb2.Checked || rb3.Checked))
            {
                flag = 1;
                costt = c3.calculate_tax3();
                remainderr = c3.remainder3(Convert.ToDouble(t2.Text));
                temp = "cost without tax= 84565.00$" + "\n" +
             "the total cost with tax=" + costt + "$" + "\n" + "the paid value=" + t2.Text + "$" + "\n" +
             "the remainder= " + remainderr + "$";
            }
            else
            {
                flag = 1;
                temp = "There is no purchase";
            }
            r1.Text = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           if (model_name == "prius_v_2018" && rb1.Checked && t2.Text != "" && flag==1)
           {
                f.counter_red++;
                f.counter_red1++;
                f.x = "red";
                f.ShowDialog();
           }
           else if (model_name == "prius_v_2018" && rb2.Checked && t2.Text != "" && flag==1)
           {
                f.counter_black++;
                f.counter_black1++;
                f.x = "black";
                f.ShowDialog();

           }
           else if (model_name == "prius_v_2018" && rb3.Checked && t2.Text != "" &&flag==1)
           {
                f.counter_white++;
                f.counter_white1++;
                f.x = "white";
                f.ShowDialog();
           }
           else if(model_name == "corolla_xle_2018" && rb1.Checked && t2.Text !="" && flag==1)
           {
                f.counter_red++;
                f.counter_red2++;
                f.x = "red1";
                f.ShowDialog();
           }
           else if (model_name == "corolla_xle_2018" && rb2.Checked && t2.Text != "" && flag == 1)
           {
                f.counter_black++;
                f.counter_black2++;
                f.x = "black1";
                f.ShowDialog();
           }
           else if (model_name == "corolla_xle_2018" && rb3.Checked && t2.Text != "" && flag == 1)
           {
                f.counter_white++;
                f.counter_white2++;
                f.x = "white1";
                f.ShowDialog();
           }
           else if (model_name == "landcruiser_2018" && rb1.Checked && t2.Text != "" && flag == 1)
           {
                f.counter_red++;
                f.counter_red3++;
                f.x = "red2";
                f.ShowDialog();
           }
           else if (model_name == "landcruiser_2018" && rb2.Checked && t2.Text != "" && flag == 1)
           {
                f.counter_black++;
                f.counter_black3++;
                f.x = "black2";
                f.ShowDialog();
           }
           else if (model_name == "landcruiser_2018" && rb3.Checked && t2.Text != "" && flag == 1)
           {
                f.counter_white++;
                f.counter_white2++;
                f.x = "white2";
                f.ShowDialog();
           }
           else
           {
               f.x = "";
               f.ShowDialog();
           }
        }

        private void r1_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
