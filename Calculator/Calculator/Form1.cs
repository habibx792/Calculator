using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstNum, secondNum;
        string operatorUsed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtScreen.Focus();

            MessageBox.Show("Wecome");
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = "9";

            }
            else
            {
                txtScreen.Text = txtScreen.Text + "9";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length > 0)
            {
                txtScreen.Text = txtScreen.Text.Remove(txtScreen.Text.Length - 1, 1);

            }
            if(txtScreen.Text=="")
            {
                txtScreen.Text = "0";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = "0";

            }
            else
            {
                txtScreen.Text = txtScreen.Text + "0";
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = "1";

            }
            else
            {
                txtScreen.Text = txtScreen.Text + "1";
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = "2";

            }
            else
            {
                txtScreen.Text = txtScreen.Text + "2";
            }


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = "3";

            }
            else
            {
                txtScreen.Text = txtScreen.Text + "3";
            }


        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = "4";

            }
            else
            {
                txtScreen.Text = txtScreen.Text + "4";
            }


        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = "5";

            }
            else
            {
                txtScreen.Text = txtScreen.Text + "5";
            }

        }

        private void bnt6_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = "6";

            }
            else
            {
                txtScreen.Text = txtScreen.Text + "6";
            }


        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = "7";

            }
            else
            {
                txtScreen.Text = txtScreen.Text + "7";
            }


        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = "8";

            }
            else
            {
                txtScreen.Text = txtScreen.Text + "8";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtScreen.Text);
            operatorUsed = "-";
            txtScreen.Text = "";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtScreen.Text);
            operatorUsed = "*";
            txtScreen.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtScreen.Text);
            operatorUsed = "÷";
            txtScreen.Text = "";
            
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double q;
            q = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = Convert.ToString(-1 * q);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNum = double.Parse(txtScreen.Text);
            switch (operatorUsed)
            {
                case "+":
                   txtScreen.Text= (firstNum + secondNum).ToString();
                    break;
                case "-":
                    txtScreen.Text = (firstNum - secondNum).ToString();
                    break;
                case "*":
                    txtScreen.Text = (firstNum * secondNum).ToString();
                    break;
                case "÷":
                    txtScreen.Text = (firstNum /secondNum).ToString();
                    break;
                case "n^":
                    txtScreen.Text = (firstNum*firstNum).ToString();
                    break;

            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtScreen.Text);
            operatorUsed = "n^";
            txtScreen.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text != "0")
            {
                txtScreen.Text = txtScreen.Text + '.';
            }
            else
            {
                txtScreen.Text = txtScreen.Text + '.';

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://chatgpt.com/");
        }

        private void txtScreen_TextChanged(object sender, EventArgs e)
        {
            
        }

      

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://superlative-cajeta-1e6b3e.netlify.app/");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtScreen.Text);
            operatorUsed = "+";
            txtScreen.Text = "";
        }
    }
}
