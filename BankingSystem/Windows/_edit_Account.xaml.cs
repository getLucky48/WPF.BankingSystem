using BankingSystem.Lib;
using System.Windows;
using System.Windows.Input;

namespace BankingSystem.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class _edit_Account : Window
    {
        public _edit_Account() 
        {

            InitializeComponent();

        }

        public _edit_Account(Bs_account obj)
        {

            InitializeComponent();

            this.account = obj;

            Balance.Text = this.account.sum.ToString();
            Name.Text = this.account.name;

        }

        private Bs_account account { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Balance.Text) || !double.TryParse(Balance.Text, out double bal))
            {

                Error failed = new Error("Ошибка", "Проверьте правильность данных");
                failed.ShowDialog();

                return;

            }


            this.account.sum = double.Parse(Balance.Text);

            Bs_account.Update(this.account.id, this.account);

            Success success = new Success("Редактирование", "Данные сохранены");
            success.ShowDialog();

            this.Close();

        }

    }

}
