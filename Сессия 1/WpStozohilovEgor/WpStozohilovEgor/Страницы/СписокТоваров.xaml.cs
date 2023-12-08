using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpStozohilovEgor.МодельБД;
namespace WpStozohilovEgor.Страницы
{
    /// <summary>
    /// Логика взаимодействия для СписокТоваров.xaml
    /// </summary>
    public partial class СписокТоваров : Page
    {
        public СписокТоваров()
        {
            InitializeComponent();
            SortList.SelectedIndex = 0;
            FilterList.SelectedIndex = 0;
        }
        private void Page_IsVisibleChange(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                bdStorozhilovEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGProducts.ItemsSource = bdStorozhilovEntities.GetContext().Products.ToList();
                Application.Current.MainWindow.Title = $"Концелярия {DGProducts.Items.Count} из {bdStorozhilovEntities.GetContext().Products.Count()}";
            }
            
        }

        private void BtnFilter_Click(object sender, RoutedEventArgs e)
        {
            if (FilterList.Text == "Все диапазоны")
            {
                DGProducts.ItemsSource = bdStorozhilovEntities.GetContext().Products.ToList();
            }
            else if (FilterList.Text == "0-9,99%")
            {
                DGProducts.ItemsSource = bdStorozhilovEntities.GetContext().Products.Where(x => x.Размер_максимально_возможной_скидки < 10).ToList();
            }
            else if (FilterList.Text == "10-14,99%")
            {
                DGProducts.ItemsSource = bdStorozhilovEntities.GetContext().Products.Where(x => x.Размер_максимально_возможной_скидки >= 10 && x.Размер_максимально_возможной_скидки < 15).ToList();
            }
            else if (FilterList.Text == "15% и более")
            {
                DGProducts.ItemsSource = bdStorozhilovEntities.GetContext().Products.Where(x => x.Размер_максимально_возможной_скидки >= 15).ToList();
            }
            Application.Current.MainWindow.Title = $"Концелярия {DGProducts.Items.Count} из {bdStorozhilovEntities.GetContext().Products.Count()}";
        }
        private void BtnSort_Click(object sender, RoutedEventArgs e)
        {
            if (SortList.Text == "По возрастанию")
            {
                DGProducts.Items.SortDescriptions.Clear();
                DGProducts.Items.SortDescriptions.Add(new SortDescription("Стоимость", ListSortDirection.Ascending));
            }
            if (SortList.Text == "По убыванию")
            {
                DGProducts.Items.SortDescriptions.Clear();
                DGProducts.Items.SortDescriptions.Add(new SortDescription("Стоимость", ListSortDirection.Descending));
            }
            if (SortList.Text == "Все значения")
            {
                DGProducts.Items.SortDescriptions.Clear();
            }
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            GetFrame.MainFrame.GoBack();
        }
    }
}
