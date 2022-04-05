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

        private void number_1_Click(object sender, EventArgs e)
        {
            equation.buildNumber("1");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
        }

        private void number_2_Click(object sender, EventArgs e)
        {
            equation.buildNumber("2");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
        }

        private void number_3_Click(object sender, EventArgs e)
        {
            equation.buildNumber("3");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
        }

        private void number_4_Click(object sender, EventArgs e)
        {
            equation.buildNumber("4");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
        }

        private void number_5_Click(object sender, EventArgs e)
        {
            equation.buildNumber("5");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
        }

        private void number_6_Click(object sender, EventArgs e)
        {
            equation.buildNumber("6");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
        }

        private void number_7_Click(object sender, EventArgs e)
        {
            equation.buildNumber("7");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
        }

        private void number_8_Click(object sender, EventArgs e)
        {
            equation.buildNumber("8");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
        }

        private void number_9_Click(object sender, EventArgs e)
        {
            equation.buildNumber("9");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
        }

        private void number_0_Click(object sender, EventArgs e)
        {
            equation.buildNumber("0");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
        }

        private void number_decimal_Click(object sender, EventArgs e)
        {
            equation.buildNumber(".");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
        }

        private void operator_equals_Click(object sender, EventArgs e)
        {
            equation.Equals();
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
            label3_a.Text = equation.operand;
        }

        private void operator_divide_Click(object sender, EventArgs e)
        {                       
            equation.Operand("/");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
            label3_a.Text = equation.operand;
        }

        private void operator_multiply_Click(object sender, EventArgs e)
        {            
            equation.Operand("*");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
            label3_a.Text = equation.operand;
        }

        private void operator_plus_Click(object sender, EventArgs e)
        {            
            equation.Operand("+");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
            label3_a.Text = equation.operand;
        }

        private void operator_minus_Click(object sender, EventArgs e)
        {            
            equation.Operand("-");
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
            label3_a.Text = equation.operand;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            equation.Clear();
            label1_a.Text = equation.number;
            label2_a.Text = equation.total;
            label3_a.Text = equation.operand;
        }
    }
}
