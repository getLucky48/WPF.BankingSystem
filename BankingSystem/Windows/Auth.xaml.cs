using BankingSystem.Lib;
using System.Windows;
using System.Windows.Input;

namespace BankingSystem.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth() 
        {
            InitializeComponent();
        }

        //Register
        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            Register register = new Register();
            register.ShowDialog();

        }

        //Login
        private void Grid_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {

            string login = Login.Text;
            string password = Utils.GetHash(Password.Password);

            Bs_user obj = new Bs_user() { login = login, password = password };

            bool isAuthorized = Bs_user.IsAuthorized(obj);

            if (isAuthorized)
            {

                //todo: get role and open window
                MessageBox.Show("Авторизован");

            }
            else
            {

                Error failed = new Error("Ошибка авторизации", "Ошибка в логине или пароле");
                failed.ShowDialog();

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
