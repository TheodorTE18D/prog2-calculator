using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string input = string.Empty;
        string operand1 = string.Empty; 
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public MainWindow()
        {
            InitializeComponent();

            
        }


        private void zeroBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            input += "0";
            this.textBoxInput.Text += input;
        }

        private void oneBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            input += "1";
            this.textBoxInput.Text += input;
        }

        private void twoBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            input += "2";
            this.textBoxInput.Text += input;
        }
        private void threeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            input += "3";
            this.textBoxInput.Text += input;
        }
        private void fourBtn_Click(object sender, RoutedEventArgs e)
        {

            this.textBoxInput.Text = "";
            input += "4";
            this.textBoxInput.Text += input;

        }

        private void fiveBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            input += "5";
            this.textBoxInput.Text += input;
        }
        private void sixBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            input += "6";
            this.textBoxInput.Text += input;
        }

        private void sevenBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            input += "7";
            this.textBoxInput.Text += input;

        }

        private void eightBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            input += "8";
            this.textBoxInput.Text += input;
        }

        private void nineBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            input += "9";
            this.textBoxInput.Text += input;
        }
        private void commaBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            input += ".";
            this.textBoxInput.Text += input;
        }

        private void squareBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            operand1 = input;
            operation = '²';
            input += "²";
            this.textBoxInput.Text += input;
        }

        private void rootBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            operand1 = input;
            operation = '√';
            input = string.Empty;
        }

        private void percentBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            operand1 = input;
            operation = '%';
            input = string.Empty;
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            bool empty;

            if(input == string.Empty)
            {
                empty = true;
            }
            else
            {
                empty = false;
            }
            if (!empty) { 
            this.textBoxInput.Text = "";
            string removeString = input.Remove(input.Length - 1, 1);
            input = removeString;
            this.textBoxInput.Text += input;
            }
            else
            {

            }
        }

        private void divideBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            operand1 = input;
            operation = '/';
            input += "/";
            this.textBoxInput.Text += input;
        }

        private void multiplicationBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            operand1 = input;
            operation = '*';
            input += "*";
            this.textBoxInput.Text += input;
        }

        private void subtractBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            operand1 = input;
            operation = '-';
            input += "-";
            this.textBoxInput.Text += input;
        }

        private void additionBtn_Click(object sender, RoutedEventArgs e)
        {
            this.textBoxInput.Text = "";
            operand1 = input;
            operation = '+';
            input += "+";
            this.textBoxInput.Text += input;
        }
        private void equalsBtn_Click(object sender, RoutedEventArgs e)
        {
            operand2 = input;
            double nmr1, nmr2;
            double.TryParse(operand1, out nmr1);
            double.TryParse(operand2, out nmr2);

            if (operation == '*')
            {  
                result = nmr1 * nmr2;
                textBoxInput.Text = result.ToString();
            }
            else if (operation == '+')
            {
                result = nmr1 + nmr2;
                textBoxInput.Text = result.ToString();
            }
            else if (operation == '-')
            {
                
                result = nmr1 - nmr2;
                textBoxInput.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if(nmr2 != 0) { 
                result = nmr1 / nmr2;
                textBoxInput.Text = result.ToString();
                }
                else
                {
                    textBoxInput.Text = "Syntax ERROR";
                }
            }
            else if (operation == '%')
            {

            }
            else if (operation == '√')
            {


            }
            else if (operation == '²')
            {


            }
            else
            {

            }
        }
    }
}
