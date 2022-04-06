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
        public Form1()
        {
            InitializeComponent();
        }

        Equation equation = new Equation();

        private void Display()
        {
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
            label3_a.Text = equation.operand;
        }

        private void number_1_Click(object sender, EventArgs e)
        {
            equation.buildNumber("1");
            Display();
        }

        private void number_2_Click(object sender, EventArgs e)
        {
            equation.buildNumber("2");
            Display();
        }

        private void number_3_Click(object sender, EventArgs e)
        {
            equation.buildNumber("3");
            Display();
        }

        private void number_4_Click(object sender, EventArgs e)
        {
            equation.buildNumber("4");
            Display();
        }

        private void number_5_Click(object sender, EventArgs e)
        {
            equation.buildNumber("5");
            Display();
        }

        private void number_6_Click(object sender, EventArgs e)
        {
            equation.buildNumber("6");
            Display();
        }

        private void number_7_Click(object sender, EventArgs e)
        {
            equation.buildNumber("7");
            Display();
        }

        private void number_8_Click(object sender, EventArgs e)
        {
            equation.buildNumber("8");
            Display();
        }

        private void number_9_Click(object sender, EventArgs e)
        {
            equation.buildNumber("9");
            Display();
        }

        private void number_0_Click(object sender, EventArgs e)
        {
            equation.buildNumber("0");
            Display();
        }

        private void number_decimal_Click(object sender, EventArgs e)
        {
            equation.buildNumber(".");
            Display();
        }

        private void operator_equals_Click(object sender, EventArgs e)
        {
            equation.Equals();
            Display();
        }

        private void operator_divide_Click(object sender, EventArgs e)
        {                       
            equation.Operand("/");
            Display();
        }

        private void operator_multiply_Click(object sender, EventArgs e)
        {            
            equation.Operand("*");
            Display();
        }

        private void operator_plus_Click(object sender, EventArgs e)
        {            
            equation.Operand("+");
            Display();
        }

        private void operator_minus_Click(object sender, EventArgs e)
        {            
            equation.Operand("-");
            Display();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            equation.Clear();
            Display();
        }
    }
}
