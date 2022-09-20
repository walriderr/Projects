using System.Linq;
using System.Windows;
namespace Project07_v7
{
    /// <summary>
    /// Логика взаимодействия для WinDelete.xaml
    /// </summary>
    public partial class WinDelete : Window
    {
        public WinDelete()
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

        private void btn_DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            if (tb_Article.Text != "")
            {
                using (var context = new MyDbContext())
                {
                    Product product = context.Products.FirstOrDefault(u => u.productArticle == tb_Article.Text);
                    context.Products.Remove(product);
                    context.SaveChanges();

                    MessageBox.Show("Готово!");
                }
            }
        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            WinCheck winCheck = new WinCheck();
            winCheck.Show();

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
