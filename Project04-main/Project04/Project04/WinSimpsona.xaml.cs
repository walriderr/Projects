using System;
using System.Collections.Generic;
using System.Windows;

namespace Project04
{
    /// <summary>
    /// Логика взаимодействия для WinSimpsona.xaml
    /// </summary>
    /// 

    public partial class WinSimpsona : Window
    {
        List<X> xList = new List<X>();

        public WinSimpsona()
        {
            InitializeComponent();
        }

        private void S_Closed(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
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

        private double Result(double a, double b, double n)
        {
            SegmentValues(a,b, n);

            double sum = 0;

            for (int i = 0; i < xList.Count; i++)
            {
               sum += xList[i].value / 2;
            }
            return sum * Steps(a,b,n);
        }

        private void btn_Result_Click(object sender, RoutedEventArgs e)
        {
            xList.Clear();

            tb_Result.Text = Result(Convert.ToDouble(tb_A.Text), Convert.ToDouble(tb_B.Text), Convert.ToDouble(tb_N.Text)).ToString();
        }
    }
}
