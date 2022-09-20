using System.Windows;

namespace Project07_v7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            WinAdd winAdd = new WinAdd();
            winAdd.Show();

            this.Close();
        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            WinCheck winCheck = new WinCheck();
            winCheck.Show();

            this.Close();
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            WinDelete winDelete = new WinDelete();
            winDelete.Show();

            this.Close();
        }
    }
}
