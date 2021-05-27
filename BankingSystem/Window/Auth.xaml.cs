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

        private void Login_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (Login.Text.Contains("Логин")) { Login.Text = ""; }

        }

        private void Password_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (Password.Password.Contains("Пароль")) { Password.Password = ""; }

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

    }

}
