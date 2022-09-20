using System;
using System.Windows;

namespace Project04
{
    /// <summary>
    /// Логика взаимодействия для WinGauss.xaml
    /// </summary>
    public partial class WinGauss : Window
    {
        public WinGauss()
        {
            InitializeComponent();
        }

        private void btn_Result_Click(object sender, RoutedEventArgs e)
        {

            double a = Convert.ToDouble(tb_a.Text);
            double b = Convert.ToDouble(tb_b.Text);
            double c = Convert.ToDouble(tb_c.Text);

            double x1 = 0;
            double x2 = 0;

            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D == 0 && D < 0)
            {
                MessageBox.Show("Нет решений!");
            }
            else
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
            }

            tb_Result1.Text = ((b - a / 2) * (x1 * ((a + b / 2) - (b - a / 2 * Math.Sqrt(3)) + x1 * ((a + b / 2) + (b - a / 2 * Math.Sqrt(3)))))).ToString();
            tb_Result2.Text = ((b - a / 2) * (x2 * ((a + b / 2) - (b - a / 2 * Math.Sqrt(3)) + x2 * ((a + b / 2) + (b - a / 2 * Math.Sqrt(3)))))).ToString();

        }

        private void S_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
