using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private decimal number1 = 0.0m;
        private decimal number2 = 0.0m;
        private decimal result = 0.0m;

        private char operand = '+';

        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if(label1.Text != "0")
            {
                label1.Text += "0";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if(label1.Text != "0") 
            {
                label1.Text += "1";
            }
            else
            {
                label1.Text = "1";

            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "2";
            }
            else
            {
                label1.Text = "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "3";
            }
            else
            {
                label1.Text = "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "4";
            }
            else
            {
                label1.Text = "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "5";
            }
            else
            {
                label1.Text = "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "6";
            }
            else
            {
                label1.Text = "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "7";
            }
            else
            {
                label1.Text = "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "8";
            }
            else
            {
                label1.Text = "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "9";
            }
            else
            {
                label1.Text = "9";
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            if(label1.Text != "0")
            {
                label1.Text = "0";
            }
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(label1.Text)  && !label1.Text.Contains(','))
            {
                label1.Text += ".";
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains('-'))
            {
                label1.Text = label1.Text.Trim('-');
            }
            else
            {
                label1.Text = '-' + label1.Text;
            }
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(label1.Text);
            label1.Text = "0";
            operand = '%';
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(label1.Text);
            label1.Text = "0";
            operand = '/';
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(label1.Text);
            label1.Text = "0";
            operand = 'x';
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(label1.Text);
            label1.Text = "0";
            operand = '-';
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(label1.Text);
            label1.Text = "0";
            operand = '+';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            switch(operand)
            {
                case '+':
                    result = number1 + decimal.Parse(label1.Text);
                    break;
                case '-':
                    result = number1 - decimal.Parse(label1.Text);
                    break;
                case 'x':
                    result = number1 * decimal.Parse(label1.Text);
                    break;
                case '/':
                    result = number1 / decimal.Parse(label1.Text);
                    break;
                case '%':
                    result = number1 % decimal.Parse(label1.Text);
                    break;
                default:
                    result = number1; 
                    break;
            }
            label1.Text = result.ToString();

        }
    }
}
