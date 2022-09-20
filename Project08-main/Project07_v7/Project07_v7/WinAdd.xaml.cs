using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace Project07_v7
{
    /// <summary>
    /// Логика взаимодействия для WinAdd.xaml
    /// </summary>
    public partial class WinAdd : Window
    {
        public WinAdd()
        {
            InitializeComponent();
        }

        private void Sb_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            this.Close();
        }

        private void btn_AddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (tb_shopNumber.Text != "" && tb_sectionNumber.Text != "" && tb_receiptNumber.Text != "" && tb_productName.Text != "" && tb_productArticle.Text != "" && tb_price.Text != "" && tb_dateOfSale.Text != "")
            {
                using (var context = new MyDbContext())
                {
                    Product product = new Product()
                    {
                        shopNumber = Convert.ToInt32(tb_shopNumber.Text),
                        sectionNumber = Convert.ToInt32(tb_sectionNumber.Text),
                        receiptNumber = Convert.ToInt32(tb_receiptNumber.Text),
                        productName = tb_productName.Text,
                        productArticle = tb_productArticle.Text,
                        price = Convert.ToInt32(tb_price.Text),
                        dateOfSale = tb_dateOfSale.Text
                    };

                    context.Products.Add(product);
                    context.SaveChanges();

                    MessageBox.Show("Готово!");
                }
            }
            else
                MessageBox.Show("Не все поля заполнены!");
        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            WinCheck winCheck = new WinCheck();
            winCheck.Show();

            this.Close();
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
