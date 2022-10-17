using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbisCalculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operationPerformed = "";
        bool isOperatedPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperatedPerformed))
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            isOperatedPerformed = false;


        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            isOperatedPerformed = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
