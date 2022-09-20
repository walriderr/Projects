using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Project05_v3
{
    /// <summary>
    /// Логика взаимодействия для WinList.xaml
    /// </summary>
    public partial class WinList : Window
    {
        public WinList()
        {
            InitializeComponent();

            Init();
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            this.Close();
        }

        private void btn_Analysis_Click(object sender, RoutedEventArgs e)
        {
            WinAnalysis winAnalysis = new WinAnalysis();
            winAnalysis.Show();

            this.Close();
        }


        private void Init()
        {
            GetInfo getInfo = new GetInfo();
            List<Vacationer> vacationersList = getInfo.GetVacationers();

            int j = 0;

            for (int i = 0; i < vacationersList.Count; i++)
            {
                Grid grid = new Grid();

                grid.ShowGridLines = false;
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());

                var bc = new BrushConverter();

                Border border = new Border
                {
                    //Width = 400,
                    //border.Height = 400;
                    BorderThickness = new Thickness(3),
                    CornerRadius = new CornerRadius(20, 20, 20, 20),
                    BorderBrush = (Brush)bc.ConvertFrom("#95d70b"),
                    Margin = new Thickness(20)
                };

                TextBlock fnText = new TextBlock
                {
                    FontFamily = new FontFamily("Arial"),
                    Foreground = Brushes.Black,
                    Margin = new Thickness(22, 20, 0, 0),
                    Width = 700,
                    FontSize = 16,
                    Text = "ФИО: " + vacationersList[i].fio + "\n"
                };

                TextBlock educationText = new TextBlock
                {
                    FontFamily = new FontFamily("Arial"),
                    Foreground = Brushes.Black,
                    Margin = new Thickness(22, 0, 0, 0),
                    FontSize = 16,
                    Text = "Образование: " + vacationersList[i].education + "\n"
                };
                TextBlock socialStatusText = new TextBlock
                {
                    FontFamily = new FontFamily("Arial"),
                    Foreground = Brushes.Black,
                    Margin = new Thickness(22, 0, 0, 0),
                    FontSize = 16,
                    Text = "Социальный статус: " + vacationersList[i].socialStatus + "\n"
                };
                TextBlock incomeText = new TextBlock
                {
                    FontFamily = new FontFamily("Arial"),
                    Foreground = Brushes.Black,
                    Margin = new Thickness(22, 0, 0, 0),
                    FontSize = 16,
                    Text = "Доход: " + vacationersList[i].income.ToString() + "₽" + "\n"
                };
                TextBlock cityText = new TextBlock
                {
                    FontFamily = new FontFamily("Arial"),
                    Foreground = Brushes.Black,
                    Margin = new Thickness(22, 0, 0, 0),
                    FontSize = 16,
                    Text = "Город отдыха: " + vacationersList[i].city + "\n"
                };
                TextBlock placeText = new TextBlock
                {
                    FontFamily = new FontFamily("Arial"),
                    Foreground = Brushes.Black,
                    Margin = new Thickness(22, 0, 0, 0),
                    FontSize = 16,
                    Text = "Местоприбывания: " + vacationersList[i].place + "\n"
                };
                TextBlock ageText = new TextBlock
                {
                    FontFamily = new FontFamily("Arial"),
                    Foreground = Brushes.Black,
                    Margin = new Thickness(22, 0, 0, 0),
                    FontSize = 16,
                    Text = "Возраст: " + vacationersList[i].age.ToString() + "\n"
                };

                TextBlock dataText = new TextBlock
                {
                    FontFamily = new FontFamily("Arial"),
                    Foreground = Brushes.Black,
                    Margin = new Thickness(22, 0, 0, 0),
                    FontSize = 16,
                    Text = "Дата прибывания: " + vacationersList[i].day.ToString() + "." + vacationersList[i].mouth.ToString() + "." + vacationersList[i].year.ToString() + "\n"
                };

                TextBlock durationRestText = new TextBlock
                {
                    FontFamily = new FontFamily("Arial"),
                    Foreground = Brushes.Black,
                    Margin = new Thickness(22, 0, 0, 0),
                    FontSize = 16,
                    Text = "Количество дней отдыха: " + vacationersList[i].durationRest.ToString() + "\n"
                };

                TextBlock amountSpentText = new TextBlock
                {
                    FontFamily = new FontFamily("Arial"),
                    Foreground = Brushes.Black,
                    Margin = new Thickness(22, 0, 0, 0),
                    FontSize = 16,
                    Text = "Потрачено на отдых: " + vacationersList[i].amountSpent.ToString() + "₽" + "\n"
                };


                border.Height = fnText.Height + educationText.Height + ageText.Height + socialStatusText.Height + placeText.Height + ageText.Height + incomeText.Height + dataText.Height + durationRestText.Height + amountSpentText.Height + 100;

                wrap.Height += border.Height;

                Grid.SetRow(fnText, 0);
                grid.Children.Add(fnText);
                Grid.SetRow(educationText, 1);
                grid.Children.Add(educationText);
                Grid.SetRow(socialStatusText, 2);
                grid.Children.Add(socialStatusText);
                Grid.SetRow(placeText, 3);
                grid.Children.Add(placeText);
                Grid.SetRow(ageText, 4);
                grid.Children.Add(ageText);
                Grid.SetRow(incomeText, 5);
                grid.Children.Add(incomeText);
                Grid.SetRow(dataText, 6);
                grid.Children.Add(dataText);
                Grid.SetRow(durationRestText, 7);
                grid.Children.Add(durationRestText);
                Grid.SetRow(amountSpentText, 8);
                grid.Children.Add(amountSpentText);

                border.Child = grid;

                wrap.Children.Add(border);

                j++;
            }
        }
    }
}

