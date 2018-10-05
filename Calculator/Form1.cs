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
        StringBuilder sbresult = new StringBuilder(9);
        bool isresult = false;
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = sbresult.ToString();
            btn0.Click += Button_Click;
            btn0.Click += Button_Click;
            btn1.Click += Button_Click;
            btn2.Click += Button_Click;
            btn3.Click += Button_Click;
            btn4.Click += Button_Click;
            btn5.Click += Button_Click;
            btn6.Click += Button_Click;
            btn7.Click += Button_Click;
            btn8.Click += Button_Click;
            btn9.Click += Button_Click;
            btnRemove.Click += Button_Click;
            btnResult.Click += Button_Click;
            btnAdd.Click += Button_Click;
            btnSubtract.Click += Button_Click;
            btnMultiply.Click += Button_Click;
            btnDivide.Click += Button_Click;
            btnDecimal.Click += Button_Click;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Form1_KeyPress(sender);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e = null)
        {
            if (lblResult.Text == "Error")
            {
                sbresult.Clear();
                lblResult.Text = sbresult.ToString();
            }
            char thischar;
            if (e == null)
            {
                Button button = (Button)sender;
                thischar = char.Parse(button.Tag.ToString());
            }
            else
            {
                thischar = e.KeyChar;
            }

            switch (thischar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    if (isresult)
                    {
                        sbresult.Clear();
                        isresult = false;
                    }
                    sbresult.Append(thischar);
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    if (!(sbresult.ToString().Length > 0 ? "+-*/.".IndexOf(sbresult.ToString()[sbresult.ToString().Length - 1]) != -1 : false))
                    {
                        sbresult.Append(thischar);
                        isresult = false;
                    }
                    break;
                case '\b':
                case 'b':
                    if (sbresult.Length > 0)
                    {
                        sbresult.Remove(sbresult.Length - 1, 1);
                    }
                    break;
                case '.':
                    if (!sbresult.ToString().EndsWith("."))
                    {
                        sbresult.Append('.');
                    }
                    break;
                case '=':
                    CalculateAnswer();
                    break;
            }
            lblResult.Text = sbresult.ToString();
        }

        public void CalculateAnswer()
        {
            string value = "Error";
            try
            {
                value = new DataTable().Compute(sbresult.ToString(), null).ToString();
            }
            catch (Exception)
            {

            }
            isresult = true;
            sbresult.Clear();
            sbresult.Append(value);


        }
    }
}
