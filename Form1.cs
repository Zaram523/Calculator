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
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void ndot_Click(object sender, EventArgs e)
        {

            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void bc_Click(object sender, EventArgs e)
        {

            textBox1.Text = "0";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            Operation = "+";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            Operation = "-";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            Operation = "/";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            Operation = "*";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Answer;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Answer = FirstNumber + SecondNumber;
                textBox1.Text = Convert.ToString(Answer);
                FirstNumber = Answer;
            }

            if (Operation == "-")
            {
                Answer = FirstNumber - SecondNumber;
                textBox1.Text = Convert.ToString(Answer);
                FirstNumber = Answer;
            }

            if (Operation == "*")
            {
                Answer = FirstNumber * SecondNumber;
                textBox1.Text = Convert.ToString(Answer);
                FirstNumber = Answer;
            }

            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "ERROR!";
                }
                else
                {
                    Answer = FirstNumber / SecondNumber;
                    textBox1.Text = Convert.ToString(Answer);
                    FirstNumber = Answer;
                }

            }

        }

        /* private void onNoBtns_Click(object sender, EventArgs e)
         {
             var btn = sender as Button;
             if (textBox1.Text == "0" && textBox1.Text != null)
             {
                 textBox1.Text = btn.Text;
             }
             else
             {
                 textBox1.Text += btn.Text;
             }
           */

    }
}
