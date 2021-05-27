using BankingSystem.Lib;
using System.Windows;
using System.Windows.Input;

namespace BankingSystem.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register() 
        {
            InitializeComponent();
        }

        //Register
        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            string login = Login.Text;
            string name = Name.Text;
            string password = Utils.GetHash(Password.Password);

            Bs_user obj = new Bs_user() { login = login, password = password, name = name, bs_role_id = 2 };

            if (Bs_user.IsExists(obj))
            {

                Error failed = new Error("Ошибка регистрации", "Пользователь с таким логином уже существует");
                failed.ShowDialog();

            }
            else
            {

                Bs_user.Add(obj);

                Success success = new Success("Регистрация завершена", "Регистрация прошла успешно.\nВернитесь к окну авторизации и войдите с введенными данными");
                success.ShowDialog();

                this.Close();

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

        private void Name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Name.Text.Contains("ФИО")) { Name.Text = ""; }
        }

        private void Name_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Name.Text)) { Name.Text = "ФИО"; }

        }

    }

}
