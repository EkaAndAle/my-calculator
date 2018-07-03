using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string firstValueText = textBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            double result = secondValue + firstValue;
            Output.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Click(object sender, EventArgs e)
        {
            double result;
            string firstValueText = textBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            switch (((Button)sender).Name)
            {
                case "Plus":
                    result = secondValue + firstValue;
                    break;
                case "Minus":
                    result = secondValue - firstValue;
                    break;
                case "Multiplication":
                    result = secondValue * firstValue;
                    break;
                case "Division":
                    result = secondValue / firstValue;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }


            Output.Text = result.ToString();
        }
    }
}
