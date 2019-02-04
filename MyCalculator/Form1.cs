using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {

        double num1 = 0.0;
        double num2 = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void v_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            label5.Text = "+";
            num1 = double.Parse(Operand1.Text);
            num2 = double.Parse(Oper2.Text);
            labResult.Text=(num1 + num2).ToString();

        }

        private void Oper2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            label5.Text = "-";
            num1 = double.Parse(Operand1.Text);
            num2 = double.Parse(Oper2.Text);
            labResult.Text = (num1 - num2).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            label5.Text = "*";
            num1 = double.Parse(Operand1.Text);
            num2 = double.Parse(Oper2.Text);
            labResult.Text = (num1 * num2).ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
           
            label5.Text = "/";
            num1 = double.Parse(Operand1.Text);
            num2 = double.Parse(Oper2.Text);
            if( num2 != 0)
            {
                labResult.Text = (num1 / num2).ToString();
            }
            else
            {
                MessageBox.Show("ERROR! Invalid Operation");
            }

        }
    }
}
