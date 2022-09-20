using System;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project111
{
    public partial class Form1 : Form
    {
        public double x = 1.4444;
        public double y = 5.8;

        public Form1()
        {
            InitializeComponent();

            label1.Text = Accuracy(x, 5.8).ToString();
        }

        public double Square(double a, double b)
        {
            double result = -2 * b * (Math.Pow(b, 2) + 2) - 2 * b * (-Math.Pow(b, 2) - 1) / (-Math.Pow(b, 2) - 1) * (Math.Pow(b, 2) + 2) - (-2 * a * (Math.Pow(a, 2) + 2) - 2 * a * (-Math.Pow(a, 2) - 1) / (-Math.Pow(a, 2) - 1) * (Math.Pow(a, 2) + 2));

            return result;
        }

        public double Accuracy(double a, double b)
        {
            double value = Square(a, b);

            string[] str = value.ToString(new NumberFormatInfo() { NumberDecimalSeparator = "," }).Split(',');
            int comma = (str.Length == 2 ? str[1].Length : 0) - 3;

            string lenght = value.ToString();

            for (int i = 0; i < comma; i++)
            {
                lenght = lenght.Remove(lenght.Length - 1);
            }

            return Convert.ToDouble(lenght);
        }
    }
}
