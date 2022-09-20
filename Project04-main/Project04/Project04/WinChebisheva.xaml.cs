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
using System.Windows.Shapes;

namespace Project04
{
    /// <summary>
    /// Логика взаимодействия для WinChebisheva.xaml
    /// </summary>
    public partial class WinChebisheva : Window
    {
        public WinChebisheva()
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
            double result = 3 * (Convert.ToDouble(tb_N.Text) - 1) - 2 * Convert.ToDouble(tb_A.Text) - Convert.ToDouble(tb_B.Text);

            tb_Result.Text = result.ToString();
        }
    }
}
