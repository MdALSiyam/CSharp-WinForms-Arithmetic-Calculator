using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticOperatorTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRightHandSide_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnAddition_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rbtnAddition.Checked)
            {
                lblExpression.Text = "Addition";
                AddTwoNumbers();
                ClearBoxes();
            }
            if (rbtnSubtraction.Checked)
            {
                lblExpression.Text = "Subtraction";
                SubtractNumbers();
                ClearBoxes();
            }
            if (rbtnMultiplication.Checked)
            {
                lblExpression.Text = "Multiplication";
                MultiplyNumbers();
                ClearBoxes();
            }
            if (rbtnDivision.Checked)
            {
                lblExpression.Text = "Division";
                DevideNumbers();
                ClearBoxes();
            }
            if (rbtnModulous.Checked)
            {
                lblExpression.Text = "Remainder";
                RemainderNumbers();
                ClearBoxes();
            }
        }

        private void ClearBoxes()
        {
            txtleftHandSide.Text = "";
            txtRightHandSide.Text = "";
        }

        private void RemainderNumbers()
        {
            int lhs = Convert.ToInt16(txtleftHandSide.Text);
            int rhs = Convert.ToInt16(txtRightHandSide.Text);
            int result = lhs % rhs;
            lblResult.Text = result.ToString();
        }

        private void DevideNumbers()
        {
            int lhs = Convert.ToInt16(txtleftHandSide.Text);
            int rhs = Convert.ToInt16(txtRightHandSide.Text);
            int result = lhs / rhs;
            lblResult.Text = result.ToString();
        }

        private void MultiplyNumbers()
        {
            int lhs = Convert.ToInt16(txtleftHandSide.Text);
            int rhs = Convert.ToInt16(txtRightHandSide.Text);
            int result = lhs * rhs;
            lblResult.Text = result.ToString();
        }

        private void SubtractNumbers()
        {
            int lhs = Convert.ToInt16(txtleftHandSide.Text);
            int rhs = Convert.ToInt16(txtRightHandSide.Text);
            int result = lhs - rhs;
            lblResult.Text = result.ToString();
        }

        private void AddTwoNumbers()
        {
            int lhs = Convert.ToInt16(txtleftHandSide.Text);
            int rhs= Convert.ToInt16(txtRightHandSide.Text);
            int result= lhs + rhs;
            lblResult.Text = result.ToString();
        }
    }
}
