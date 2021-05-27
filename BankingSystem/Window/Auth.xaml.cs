using BankingSystem.Lib;
using System.Windows;
using System.Windows.Input;

namespace BankingSystem
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

        //Register
        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            

        }

        //Login
        private void Grid_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {

            if (string.IsNullOrEmpty(Login.Text)) { return; }
            if (string.IsNullOrEmpty(Password.Password)) { return; }

            string login = Login.Text;
            string password = Utils.GetHash(Password.Password);

            Bs_user obj = new Bs_user() { login = login, password = password };

            bool isAuthorized = Bs_user.IsAuthorized(obj);

            if (isAuthorized)
            {

                MessageBox.Show("Авторизован");

            }
            else
            {

                MessageBox.Show("Ошибка авторизации");

            }

        }

        private void LoginFocus(object sender, RoutedEventArgs e)
        {


            if (Login.Text.Contains("Логин")) { Login.Text = ""; }

        }

        private void Login_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Login.Text)) { Login.Text = "Логин"; }

        }

        private void Password_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Password.Password)) { Password.Password = "Пароль"; }

        }

        private void Password_GotFocus(object sender, RoutedEventArgs e)
        {

            if (Password.Password.Contains("Пароль")) { Password.Password = ""; }

        }

    }

}
