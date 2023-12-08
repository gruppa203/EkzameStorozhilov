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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpStozohilovEgor.МодельБД;

namespace WpStozohilovEgor.Страницы
{
    /// <summary>
    /// Логика взаимодействия для Логин.xaml
    /// </summary>
    public partial class Логин : Page
    {
        public Логин()
        {
            InitializeComponent();
        }
        private void BtnToComeIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = bdStorozhilovEntities.GetContext().Users.FirstOrDefault(x => x.Логин == TextBoxLogin.Text && x.Пароль == PasswordBoxPassword.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Пользователь с таким логином и паролем не найден!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                else
                {
                    MessageBox.Show($"Добро пожаловать {userObj.Имя_Отчество}");
                    GetFrame.MainFrame.Navigate(new СписокТоваров());
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка:" + Ex.Message.ToString(), "Критическая работа приложения", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
