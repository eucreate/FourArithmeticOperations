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

namespace FourArithmeticOperations
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Addition(double a, double b)
        {
            double addResult;
            addResult = a + b;
            result.Inlines.Add(new Run("a + b = " + addResult + "\n"));
        }

        private void Subtraction(double a, double b)
        {
            double subResult;
            subResult = a - b;
            result.Inlines.Add(new Run("a - b = " + subResult + "\n"));
        }

        private void Multiplication(double a, double b)
        {
            double multiResult;
            multiResult = a * b;
            result.Inlines.Add(new Run("a × b = " + multiResult + "\n"));
        }

        private void Division(double a, double b)
        {
            double divResult;
            if (b == 0)
            {
                result.Inlines.Add(new Run("Oops, you cannot divide by 0!\n"));
            }
            else
            {
                divResult = a / b;
                result.Inlines.Add(new Run("a / b = " + divResult + "\n"));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a, b;
            a = double.Parse(aInput.Text);
            b = double.Parse(bInput.Text);
            result.Text = "";
            Addition(a, b);
            Subtraction(a, b);
            Multiplication(a, b);
            Division(a, b);
        }
    }
}
