using System;
using System.Windows;
using System.Data.Entity;

namespace Project07_v7
{
    /// <summary>
    /// Логика взаимодействия для WinEdit.xaml
    /// </summary>
    public partial class WinEdit : Window
    {
        private Product product;
        public WinEdit(Product product)
        {
            InitializeComponent();

            this.product = product;

            tb_productArticle.Text = product.productArticle;
            tb_shopNumber.Text = product.shopNumber.ToString();
            tb_sectionNumber.Text = product.sectionNumber.ToString();
            tb_receiptNumber.Text = product.receiptNumber.ToString();
            tb_price.Text = product.price.ToString();
            tb_productName.Text = product.productName.ToString();
            tb_dateOfSale.Text = product.dateOfSale.ToString();
            tb_productArticle.IsReadOnly = true;
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

        private void btn_EditProduct_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbContext())
            {
                Product product = new Product
                {
                    productArticle = tb_productArticle.Text,
                    shopNumber = Convert.ToInt32(tb_shopNumber.Text),
                    sectionNumber = Convert.ToInt32(tb_sectionNumber.Text),
                    receiptNumber = Convert.ToInt32(tb_receiptNumber.Text),
                    price = Convert.ToInt32(tb_price.Text),
                    productName = tb_productName.Text,
                    dateOfSale = tb_dateOfSale.Text                 
                };

                //context.Entry(product).State = EntityState.Modified;
                context.Products.Update(product);
                context.SaveChanges();

                MessageBox.Show("Готово!");


                //Product product = context.Products.FirstOrDefault(u => u.productArticle == tb_Article.Text);        

            }
        }
    }
}
