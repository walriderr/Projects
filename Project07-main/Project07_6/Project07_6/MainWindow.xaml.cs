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

namespace Project07_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    ///
    public static class Helpers
    {
        public static string Print(this List<int> sequence)
        {
            string str = "";

            sequence.ForEach(item => str = item + " ");
            return str;
        }

        public static string PringGistogramm(List<int> sequence, int gistogrammsCount)
        {
            string str = "";

            str += "Gistogramm Graph: \n";
            int minValue = sequence.Min();
            int maxValue = sequence.Max();
            int step = (maxValue - minValue) / gistogrammsCount;
            if (step == 0) step = 1;
            str += "\t\t/*****************************\n";
            for (int currentBegin = minValue; currentBegin < maxValue; currentBegin += step)
            {
                int itemsCount = sequence.Count(item => item >= currentBegin && item < currentBegin + step);
                str += currentBegin + "-" + (currentBegin + step) + "\t(" + itemsCount + ")\t|";
                str += "0".PadLeft(itemsCount, '0');
            }

            return str;
        }
    }

    public static class Constants
    {
        public const int N = 100;
        public const int FROM_RANGE = 1;
        public const int TO_RANGE = 10;
        public const int INTERVALS_COUNT = 10;
    }

    public static class CustomRandom
    {
        public static List<int> GenegateSequence(int n, int from, int to)
        {
            List<int> result = new List<int>();
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                result.Add(from + random.Next(to - from));
            }

            return result;
        }

        public static List<int> GenerateNewSequence(List<int> oldSequence)
        {
            List<int> result = new List<int>();
            // y_1 = x_1
            result.Add(oldSequence.First());

            for (int i = 1; i < oldSequence.Count; i++)
            {
                result.Add(result[i - 1] + oldSequence[i]);
            }

            return result;
        }
    }

    public static class StatisticCalculator
    {
        public static double GetMathematicalExpectation(List<int> sequence)
        {
            return sequence.Average();
        }
        public static double GetDispersion(List<int> sequence)
        {
            double matExpr = GetMathematicalExpectation(sequence);

            return sequence.Sum(item => item * item - matExpr * matExpr) / sequence.Count;
        }
    }


    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "";

            var sequence = CustomRandom.GenegateSequence(Constants.N, Constants.FROM_RANGE, Constants.TO_RANGE);
            sequence.Print();

            var newSequence = CustomRandom.GenerateNewSequence(sequence);
            tb.Text += newSequence.Print();

            tb.Text += Helpers.PringGistogramm(sequence, Constants.INTERVALS_COUNT);
            tb.Text += Helpers.PringGistogramm(newSequence, Constants.INTERVALS_COUNT);

            //Console.WriteLine("Press Enter to continue, other key to Exit");
            //string continueString = Console.ReadLine();
            //continueFlag = continueString.Count() == 0;

        }

    }
}
