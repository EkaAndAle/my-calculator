using System;

using System.Windows.Forms;
using WindowsFormsApplication1.OneArgumentFolder;
using WindowsFormsApplication1.TwoArgumentsFolder;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Click(object sender, EventArgs e)
        {
            try
            {
                string firstValueText = textBox1.Text;
                double firstValue = Convert.ToDouble(firstValueText);
                string secondValueText = textBox2.Text;
                double secondValue = Convert.ToDouble(secondValueText);
                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button) sender).Name);
                double result = calculator.Calculate(firstValue, secondValue);
                Output.Text = result.ToString();
            }
            catch (Exception exc)
            {
                Output.Text = exc.Message;
            }

        }
        private void Click1(object sender, EventArgs e)
        {
            try
            {
                string firstValueText = textBox1.Text;
                double firstValue = Convert.ToDouble(firstValueText);
                IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button) sender).Name);
                double result = calculator.Calculate(firstValue);
                Output.Text = result.ToString();
            }
            catch (Exception exc)
            {
                Output.Text = exc.Message;
            }
            
        }



  
    }
}
