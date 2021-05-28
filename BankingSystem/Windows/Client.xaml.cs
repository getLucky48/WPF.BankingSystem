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
    public partial class Client : Window
    {

        public List<Bs_account> accountList { get; set; }

        public Client()
        {

            InitializeComponent();

        }

        public Client(int userId)
        {
            
            InitializeComponent();

            this.userId = userId;

            refreshAcc();
            refreshTable();

        }

        private int userId { get; set; }

        private void refreshAcc()
        {

            this.accountList = Bs_account.GetList(this.userId);
            Accounts.ItemsSource = this.accountList;

            if(this.accountList.Count != 0) { Accounts.SelectedIndex = 0; }

        }

        private void Label_MouseUp(object sender, MouseButtonEventArgs e)
        {

            Bs_account.Add(new Bs_account() { bs_user_id = userId });

            Success success = new Success("Счет открыт", "Счет успешно открыт!");
            success.ShowDialog();

            refreshAcc();
            refreshTable();

        }

        private void Accounts_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            refreshTable();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewTransaction newTransaction = new NewTransaction(this.userId);
            newTransaction.ShowDialog();

            refreshAcc();
            refreshTable();

        }

        private void refreshTable()
        {



            //todo

        }

        private void Label_MouseUp_1(object sender, MouseButtonEventArgs e)
        {

            Deposit deposit = new Deposit(this.userId);
            deposit.ShowDialog();

            refreshAcc();
            refreshTable();

        }

        private void Label_MouseUp_2(object sender, MouseButtonEventArgs e)
        {

            Withdraw withdraw = new Withdraw(this.userId);
            withdraw.ShowDialog();

            refreshAcc();
            refreshTable();

        }

    }

}
