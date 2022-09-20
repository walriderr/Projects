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

namespace Project_DemEkz
{
    /// <summary>
    /// Логика взаимодействия для WinSuppliers.xaml
    /// </summary>
    public partial class WinSuppliers : Window
    {
        public WinSuppliers()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            this.Close();
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            WinEdit winEdit = new WinEdit();
            winEdit.Show();

            this.Close();
        }
    }
}
