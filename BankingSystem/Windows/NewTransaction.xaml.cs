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
    public partial class NewTransaction : Window
    {

        public List<Bs_account> accountList { get; set; }

        public NewTransaction()
        {

            InitializeComponent();

        }

        public NewTransaction(int userId)
        {
            
            InitializeComponent();

            this.userId = userId;

            this.accountList = Bs_account.GetList(this.userId);

            Accounts.ItemsSource = this.accountList;

        }

        private int userId { get; set; }

        private void Label_MouseUp(object sender, MouseButtonEventArgs e)
        {

            Bs_account.Add(new Bs_account() { bs_user_id = userId });

            Success success = new Success("Счет открыт", "Счет успешно открыт!");
            success.ShowDialog();

        }

        private void Sum_GotFocus(object sender, RoutedEventArgs e)
        {

            if(Sum.Text.Equals("Сумма в рублях")) { Sum.Text = ""; }

        }

        private void Sum_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Sum.Text)) { Sum.Text = "Сумма в рублях"; }

        }

        private void AccountDist_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(AccountDist.Text)) { AccountDist.Text = "Номер счета"; }

            //todo name client

        }

        private void AccountDist_GotFocus(object sender, RoutedEventArgs e)
        {

            if(AccountDist.Text.Equals("Номер счета")) { AccountDist.Text = ""; }

        }

        private void Descr_LostFocus(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Descr.Text)) { Descr.Text = "Комментарий"; }

        }

        private void Descr_GotFocus(object sender, RoutedEventArgs e)
        {

            if (Descr.Text.Equals("Комментарий")) { Descr.Text = ""; }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //todo проверка на наличие такой суммы

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
            else if (sum <= 0)
            {

                Error error = new Error("Ошибка", "Некорректная сумма перевода");
                error.ShowDialog();

                return;

            }

            if (!Bs_account.IsExists(new Bs_account() { name = AccountDist.Text }))
            {

                Error error = new Error("Ошибка", "Получатель не найден");
                error.ShowDialog();

                return;

            }

            int distId = Bs_account.GetID(AccountDist.Text);
            int srcId = ((Bs_account)Accounts.SelectedItem).id;


            if (distId == -1)
            {

                Error error = new Error("Ошибка", "Непредвиденная ошибка. Повторите операцию позднее или обратитесь в техподдержку");
                error.ShowDialog();

                return;

            }

            Bs_transaction transaction = new Bs_transaction()
            {

                sum = double.Parse(Sum.Text),
                descr = Descr.Text,
                bs_account_id_src = srcId,
                bs_account_id_dist = distId

            };

            Bs_transaction.Add(transaction);

            Success success = new Success("Перевод выполнен", "Перевод успешно выполнен!");
            success.ShowDialog();

            this.Close();

        }

    }

}
