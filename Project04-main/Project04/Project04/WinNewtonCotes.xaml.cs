using System;
using System.Collections.Generic;
using System.Windows;

namespace Project04
{
    /// <summary>
    /// Логика взаимодействия для WinNewtonCotes.xaml
    /// </summary>
    public partial class WinNewtonCotes : Window
    {
        List<X> xList = new List<X>();
        List<X> fxList = new List<X>();


        public WinNewtonCotes()
        {
            InitializeComponent();
        }

        private void S_Closed(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void btn_Result_Click(object sender, RoutedEventArgs e)
        {
            xList.Clear();
            fxList.Clear();

            tb_Result.Text = Result(Convert.ToDouble(tb_A.Text), Convert.ToDouble(tb_B.Text), Convert.ToDouble(tb_N.Text)).ToString();
        }

        private double Steps(double a, double b, double n)
        {
            return (b - a) / n;
        }

        private void SegmentValues(double a, double b, double n)
        {
            double xn = a;

            for (int i = 0; i < n; i++)
            {
                X x = new X();

                xn += Steps(a, b, n);

                x.value = xn;
                xList.Add(x);
            }
        }

        private void Function(double a, double b, double n)
        {
            for (int i = 0; i < xList.Count; i++)
            {
                X x = new X();

                x.value = 1 / Math.Log(xList[i].value);

                fxList.Add(x);
            }
        }

        private double Result(double a, double b, double n)
        {
            SegmentValues(a, b, n);
            Function(a, b, n);

            double sum = 0;
            for (int i = 0; i < fxList.Count; i++)
            {
                sum += fxList[i].value / 2;
            }
            return sum * Steps(a, b, n);
        }


    }
}
