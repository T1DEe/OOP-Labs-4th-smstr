using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab01
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public string get_inputField()
        {
            return inputField.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            inputField.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            inputField.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            inputField.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            inputField.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            inputField.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            inputField.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            inputField.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            inputField.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            inputField.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            inputField.Text += "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            inputField.Text += ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inputField.Text = "";
            tmp = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text.Remove(inputField.Text.Length - 1);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (inputField.Text[0] != '-')
                inputField.Text = inputField.Text.Insert(0, "-");
            else
                inputField.Text = inputField.Text.Remove(0, 1);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = Operations.Plus;
            tmp = double.Parse(inputField.Text);
            inputField.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = Operations.Minus;
            tmp = double.Parse(inputField.Text);
            inputField.Text = "";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operation = Operations.Multi;
            tmp = double.Parse(inputField.Text);
            inputField.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = Operations.Div;
            tmp = double.Parse(inputField.Text);
            inputField.Text = "";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case (Operations.Plus):
                    if (inputField.Text != "")
                        inputField.Text = (tmp + double.Parse(inputField.Text)).ToString();
                    break;

                case (Operations.Minus):
                    if(inputField.Text != "")
                        inputField.Text = (tmp - double.Parse(inputField.Text)).ToString();
                    break;

                case (Operations.Div):
                    if (inputField.Text != "")
                        inputField.Text = (tmp / double.Parse(inputField.Text)).ToString();
                    break;

                case (Operations.Multi):
                    if (inputField.Text != "")
                        inputField.Text = (tmp * double.Parse(inputField.Text)).ToString();
                    break;

                case (Operations.Null):

                    break;

            }
            operation = Operations.Null;
            tmp = 0;
        }

        private void inputField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
