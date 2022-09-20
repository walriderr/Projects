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
using System.Data.SqlClient;
using System.Data;

namespace Project_DemEkz
{
    /// <summary>
    /// Логика взаимодействия для WinEdit.xaml
    /// </summary>
    public partial class WinEdit : Window
    {
        DataBase dataBase = new DataBase();

        public WinEdit()
        {
            InitializeComponent();

        }

        private void btnList_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            this.Close();
        }   

        private void btnSuppliers_Click(object sender, RoutedEventArgs e)
        {
            WinSuppliers winSuppliers = new WinSuppliers();
            winSuppliers.Show();

            this.Close();
        }

        private void AddMaterial()
        {
            if (CheckPosition())
            {
                string name = tbName.Text;
                string category = tbCategory.Text;
                int price = Convert.ToInt32(tbPrice.Text);
                string postavka = tbPostavka.Text;

                string quereString = $"INSERT INTO materials(name,category,price,postavka) values('{name}', '{category}', '{price}', '{postavka}')";

                SqlCommand sqlCommand = new SqlCommand(quereString, dataBase.GetConnection());

                dataBase.OpenConnection();

                if (sqlCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Успешно!");
                else
                    MessageBox.Show("Товар не добавлен!");

                dataBase.CloseConnection();
            }
        }

        private Boolean CheckPosition()
        {
            string name = tbName.Text;
            string category = tbCategory.Text;
            int price = Convert.ToInt32(tbPrice.Text);
            string postavka = tbPostavka.Text;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            DataTable dataTable = new DataTable();

            string quereString = $"select id , name, category, price, postavka from materials  where name = '{name}' and category = '{category}' and price = '{price}' and postavka = '{postavka}' ";

            SqlCommand sqlCommand = new SqlCommand(quereString, dataBase.GetConnection());            

            sqlDataAdapter.SelectCommand = sqlCommand;

            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 1)
            {
                MessageBox.Show("Товар уже существует!");
                return false;
            }
            else
                return true;         
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddMaterial();
        }
    }
}
