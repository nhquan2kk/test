using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH1
{
    public partial class Calculator : Form
    {
        string sign;
        double val1;
        double val2;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn0.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnDot.Text;
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn5.Text;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn9.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            val1 = 0;
            val2 = 0;
            sign = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(txtResult.Text);
            txtResult.Text = "";
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            sign = "-";
            val1 = double.Parse(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            sign = "SQRT";
            val1 = double.Parse(txtResult.Text);
       
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(txtResult.Text);
            double result;
            if (sign == "+")
            {
                result = val1 + val2;
                txtResult.Text = result.ToString();
            }
            else
                if(sign == "-")
            {
                result = val1 - val2;
                txtResult.Text = result.ToString();
            }
            if(sign == "*")
            {
                result = val1 * val2;
                txtResult.Text = result.ToString();
            }
            if(sign == "/")
            {
                result = val1 / val2;
                txtResult.Text = result.ToString();
            }
            if(sign == "SQRT")
            {
                result = Math.Sqrt(val1);
                txtResult.Text = result.ToString();
            }
        }
    }
}
