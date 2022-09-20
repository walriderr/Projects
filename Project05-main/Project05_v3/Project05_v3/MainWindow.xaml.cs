using System.Windows;

namespace Project05_v3
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

        private void btn_List_Click(object sender, RoutedEventArgs e)
        {
            WinList winList = new WinList();
            winList.Show();

            this.Close();
        }

        private void btn_Analysis_Click(object sender, RoutedEventArgs e)
        {
            WinAnalysis winAnalysis = new WinAnalysis();
            winAnalysis.Show();

            this.Close();
        }
    }
}
