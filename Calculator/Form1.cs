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
        StringBuilder sb = new StringBuilder();
        decimal value1;
        decimal value2;
        decimal result = 0;
        decimal temp;
        char symbol;
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = sb.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            var length = sb.Length;
            if (length > 0)
            {
                sb.Remove(length - 1, 1);
                lblResult.Text = sb.ToString();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            sb.Append(1);
            lblResult.Text = sb.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            sb.Append(2);
            lblResult.Text = sb.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            sb.Append(3);
            lblResult.Text = sb.ToString();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            sb.Append(4);
            lblResult.Text = sb.ToString();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            sb.Append(5);
            lblResult.Text = sb.ToString();

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            sb.Append(6);
            lblResult.Text = sb.ToString();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            sb.Append(7);
            lblResult.Text = sb.ToString();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            sb.Append(8);
            lblResult.Text = sb.ToString();

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            sb.Append(9);
            lblResult.Text = sb.ToString();

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            sb.Append(0);
            lblResult.Text = sb.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (sb.Length > 0)
            {
                value1 = decimal.Parse(sb.ToString());
            }
            else
                value1 = result;
            symbol = '+';
            sb.Clear();
        }


        private void btnSubtract_Click(object sender, EventArgs e)
        {
            value1 = decimal.Parse(sb.ToString());
            symbol = '-';
            sb.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            value1 = decimal.Parse(sb.ToString());
            symbol = '*';
            sb.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            value1 = decimal.Parse(sb.ToString());
            symbol = '/';
            sb.Clear();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            value2 = decimal.Parse(sb.ToString());
            switch (symbol)
            {
                case '+':
                    result = value1 + value2;
                    break;
                case '-':
                    result = value1 - value2;
                    break;
                case '*':
                    result = value1 * value2;
                    break;
                case '/':
                    result = value1 / value2;
                    break;

            }
            sb.Clear();
            lblResult.Text = result.ToString();
        }

    }
}
