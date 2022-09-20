using System.Collections.Generic;
using System.Windows;

namespace Project05_v3
{
    /// <summary>
    /// Логика взаимодействия для WinAnalysis.xaml
    /// </summary>
    public partial class WinAnalysis : Window
    {
        public WinAnalysis()
        {
            InitializeComponent();

            Init();
        }

        public void Init()
        {
            PopularCity();

            Dependence();

            Trand();
        }

        public void PopularCity()
        {
            GetInfo getInfo = new GetInfo();
            List<Vacationer> vacationersList = getInfo.GetVacationers();

            for (int i = 0; i < vacationersList.Count; i++)
            {
                tb_PopularCity.Text += $"{i + 1}){vacationersList[i].city}\n";
            }
        }

        public void Dependence()
        {
            GetInfo getInfo = new GetInfo();
            List<Vacationer> vacationersList = getInfo.GetVacationers();

            int i = 0;

            double dependence = 0;

            for (i = 0; i < vacationersList.Count; i++)
            {
                dependence += vacationersList[i].income - vacationersList[i].amountSpent;
            }

            double sr_znach = dependence / i;

            if (sr_znach < 0)
                sr_znach *= -1;

            tb_Dependence.Text += sr_znach.ToString() + " Рублей";
        }

        public void Trand()
        {
            GetInfo getInfo = new GetInfo();
            List<Vacationer> vacationersList = getInfo.GetVacationers();

            int summer = 0;
            int autumn = 0;
            int winter = 0;
            int spring = 0;

            for (int i = 0; i < vacationersList.Count; i++)
            {
                switch (vacationersList[i].mouth)
                {
                    case 6:
                    case 7:
                    case 8:
                        summer += 1;
                        break;

                    case 9:
                    case 10:
                    case 11:
                        autumn += 1;
                        break;

                    case 12:
                    case 1:
                    case 2:
                        winter += 1;
                        break;

                    case 3:
                    case 4:
                    case 5:
                        spring += 1;
                        break;
                }
            }

            tb_Trend.Text = $"Летом: {summer} человек\n" +
                $"Осенью: {autumn} человек\n" +
                $"Зимой: {winter} человек\n" +
                $"Весной: {spring} человек\n";
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            this.Close();
        }

        private void btn_List_Click(object sender, RoutedEventArgs e)
        {
            WinList winList = new WinList();
            winList.Show();

            this.Close();
        }

        private void btn_OpenGraphic_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
