using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorNumberHoodini
{
    public partial class Calculator : Form
    {
        String output;
        double operand1;
        double operand2;
        String opp;
        public Calculator()
        {
            InitializeComponent();
        }

        private void ouput_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            //Output String
            output = "0";
            //Setting labels and buttons to correct text
            output_lbl.Text = "0";
            num0_btn.Text = "0";
            num1_btn.Text = "1";
            num2_btn.Text = "2";
            num3_btn.Text = "3";
            num4_btn.Text = "4";
            num5_btn.Text = "5";
            num6_btn.Text = "6";
            num7_btn.Text = "7";
            num8_btn.Text = "8";
            num9_btn.Text = "9";

            operand1 = 1;
            operand2 = 2;
            opp = "+";
            Console.WriteLine(operand1 + operand2);
        }
        
        private void num0_btn_Click(object sender, EventArgs e)
        {

            if(output == "0")
            {
                output = "0";
            }
            else
            {
                output = output + "0";
            }
            output_lbl.Text = output;
        }

        private void num1_btn_Click(object sender, EventArgs e)
        {
            
            if (output == "0")
            {
                output = "1";
            }
            else
            {
                output = output + "1";
            }
            output_lbl.Text = output;           
        }

        private void num2_btn_Click(object sender, EventArgs e)
        {
           
            if (output == "0")
            {
                output = "2";
            }
            else
            {
                output = output + "2";
            }
            output_lbl.Text = output;
        }

        private void num3_btn_Click(object sender, EventArgs e)
        {
           
            if (output == "0")
            {
                output = "3";
            }
            else
            {
                output = output + "3";
            }
            output_lbl.Text = output;
        }

        private void num4_btn_Click(object sender, EventArgs e)
        {
           
            if (output == "0")
            {
                output = "4";
            }
            else
            {
                output = output + "4";
            }
            output_lbl.Text = output;
        }

        private void num5_btn_Click(object sender, EventArgs e)
        {
           
            if (output == "0")
            {
                output = "5";
            }
            else
            {
                output = output + "5";
            }
            output_lbl.Text = output;
        }

        private void num6_btn_Click(object sender, EventArgs e)
        {
            
            if (output == "0")
            {
                output = "6";
            }
            else
            {
                output = output + "6";
            }
            output_lbl.Text = output;
        }

        private void num7_btn_Click(object sender, EventArgs e)
        {
           
            if (output == "0")
            {
                output = "7";
            }
            else
            {
                output = output + "7";
            }
            output_lbl.Text = output;
        }

        private void num8_btn_Click(object sender, EventArgs e)
        {
            
            if (output == "0")
            {
                output = "8";
            }
            else
            {
                output = output + "8";
            }
            output_lbl.Text = output;
        }

        private void num9_btn_Click(object sender, EventArgs e)
        {
           
            if (output == "0")
            {
                output = "9";
            }
            else
            {
                output = output + "9";
            }
            output_lbl.Text = output;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            output = "0";
            output_lbl.Text = output;
            opp = "";
            operand1 = 0;
            operand2 = 0;
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(output);
            opp = "+";
            output = "0";
            output_lbl.Text = output;
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(output);
            opp = "-";
            output = "0";
            output_lbl.Text = output;
        }

        private void mult_btn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(output);
            opp = "*";
            output = "0";
            output_lbl.Text = output;
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(output);
            opp = "/";
            output = "0";
            output_lbl.Text = output;
        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            double x = 0;
            operand2 = double.Parse(output);
            if (opp == "+")
            {
                x = operand1 + operand2;
                
            }
            else if (opp == "-")
            {
                x = operand1 - operand2;
            }
            else if (opp == "*")
            {
                x = operand1 * operand2;
            }
            else if (opp == "/")
            {
                if (operand2 == 0)
                {
                    x = 0;
                }
                else
                {
                    x = operand1 / operand2;
                }
                
            }
            else
            {
                output = "0";
            }

            output = x.ToString();
            output_lbl.Text = output;
        }
    }
}
