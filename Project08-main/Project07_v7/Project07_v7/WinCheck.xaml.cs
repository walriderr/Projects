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

namespace Project07_v7
{
    /// <summary>
    /// Логика взаимодействия для WinCheck.xaml
    /// </summary>
    public partial class WinCheck : Window
    {
        public WinCheck()
        {
            InitializeComponent();
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            this.Close();
        }

        private void btn_Find_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbContext())
            {
                if (context.Products.FirstOrDefault(u => u.productArticle == tb_Article.Text).productArticle == tb_Article.Text)
                {
                    Product product = context.Products.FirstOrDefault(u => u.productArticle == tb_Article.Text);

                    WinEdit winEdit = new WinEdit(product);
                    winEdit.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Продукт не найден!\nПроверте написание артикула...");
                }
            }
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            WinDelete winDelete = new WinDelete();
            winDelete.Show();

            this.Close();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            WinAdd winAdd = new WinAdd();
            winAdd.Show();

            this.Close();
        }
    }
}
