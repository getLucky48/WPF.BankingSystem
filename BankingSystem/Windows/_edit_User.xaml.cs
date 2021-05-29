using BankingSystem.Lib;
using System.Windows;
using System.Windows.Input;

namespace BankingSystem.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class _edit_User : Window
    {
        public _edit_User() 
        {

            InitializeComponent();

        }

        public _edit_User(Bs_user obj)
        {

            InitializeComponent();

            this.user = obj;

            Login.Text = this.user.login;
            Name.Text = this.user.name;

        }

        private Bs_user user { get; set; }
 
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string login = Login.Text;
            string name = Name.Text;
            string password = Utils.GetHash(Password.Password);

            Bs_user temp = new Bs_user() { login = login, password = password, name = name, bs_role_id = 3 };

            if (Bs_user.IsExists(temp))
            {

                Error failed = new Error("Ошибка", "Пользователь с таким логином уже существует");
                failed.ShowDialog();

                return;

            }

            this.user.login = temp.login;
            this.user.password = temp.password;
            this.user.name = temp.name;

            Bs_user.Update(this.user.id, this.user);

            Success success = new Success("Редактирование", "Данные сохранены");
            success.ShowDialog();

            this.Close();

        }

    }

}
