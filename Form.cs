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
        Double firstNum = 0;
        String operationPerfomed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((TextBox.Text == "0") || (isOperationPerformed))
            {
                TextBox.Clear();
                TextBox.Text = TextBox.Text;
            }

            isOperationPerformed = false;
            Button button=(Button)sender;
            if (button.Text == ".")
            {
                
                if (!TextBox.Text.Contains("."))
                    TextBox.Text = TextBox.Text + button.Text;
            }
            else
            {
                TextBox.Text = TextBox.Text + button.Text;
            }
        }

        private void operation_click(object sender, EventArgs e)
        {
            firstNum = Double.Parse(TextBox.Text);
            Button button = (Button)sender;
            if (firstNum != 0)
            {
                button21.PerformClick();
                operationPerfomed = button.Text;
                labCurrentOperation.Text = firstNum + " " + operationPerfomed;
                isOperationPerformed = true;
                //TextBox.Clear();
            }
            else
            {
                operationPerfomed = button.Text;
                //firstNum = Double.Parse(TextBox.Text);
                labCurrentOperation.Text = firstNum + " " + operationPerfomed;
                isOperationPerformed = true;
                //TextBox.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            TextBox.Text="0";
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox.Text="0";
            firstNum = 0 ;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            double secNum = Double.Parse(TextBox.Text);
            
            switch (operationPerfomed)
            {
                case "+":
                    TextBox.Text=(firstNum+ secNum).ToString();
                    break;
                case "-":
                    TextBox.Text = (firstNum - secNum).ToString();
                    break;
                case "*":
                    TextBox.Text = (firstNum * secNum).ToString();
                    break;
                case "/":
                    TextBox.Text = (firstNum / secNum).ToString();
                    break;
                case "x^2":
                    TextBox.Text = (Math.Pow(firstNum, 2)).ToString();
                    break;
                case "x^3":
                    TextBox.Text = (Math.Pow(firstNum, 3)).ToString();
                    break;
                case "sqrt":
                    TextBox.Text = (Math.Pow(firstNum, (double)1 / 2)).ToString();
                    break;
                case "rootcube":
                    TextBox.Text = (Math.Pow(firstNum, (double)1 / 3)).ToString();
                    break;
                default:
                    break;

            }

            isOperationPerformed = true;
            //firstNum = Double.Parse(TextBox.Text);
            labCurrentOperation.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            firstNum = Double.Parse(TextBox.Text);
            operationPerfomed = "x^2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            firstNum = Double.Parse(TextBox.Text);
            operationPerfomed = "x^3";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            firstNum = Double.Parse(TextBox.Text);
            operationPerfomed = "sqrt";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstNum = Double.Parse(TextBox.Text);
            operationPerfomed = "rootcube";
        }
    }
}
