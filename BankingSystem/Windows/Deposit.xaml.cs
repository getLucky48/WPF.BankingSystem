using BankingSystem.Lib;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace BankingSystem.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Deposit : Window
    {

        public List<Bs_account> accountList { get; set; }

        public Deposit()
        {

            InitializeComponent();

        }

        public Deposit(int userId)
        {
            
            InitializeComponent();

            this.userId = userId;

            this.accountList = Bs_account.GetList(this.userId);

            Accounts.ItemsSource = this.accountList;

        }

        private int userId { get; set; }

        private void Sum_GotFocus(object sender, RoutedEventArgs e)
        {

            if(Sum.Text.Equals("Сумма в рублях")) { Sum.Text = ""; }

        }

        private void Sum_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Sum.Text)) { Sum.Text = "Сумма в рублях"; }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Accounts.SelectedIndex == -1)
            {

                Error error = new Error("Ошибка", "Вы не выбрали счет списания");
                error.ShowDialog();

                return;

            }

            if (!double.TryParse(Sum.Text, out double sum))
            {

                Error error = new Error("Ошибка", "Некорректная сумма перевода");
                error.ShowDialog();

                return;

            }
            else if(sum <= 0)
            {

                Error error = new Error("Ошибка", "Некорректная сумма перевода");
                error.ShowDialog();

                return;

            }

            int srcId = ((Bs_account)Accounts.SelectedItem).id;

            Bs_account.Deposit(srcId, double.Parse(Sum.Text));

            Success success = new Success("Счет пополнен", $"Счет успешно пополнен.\nВаш баланс: {Bs_account.GetActualBalance(srcId)}");
            success.ShowDialog();

            this.Close();

        }

    }

}
