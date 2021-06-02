using BankingSystem.Lib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace BankingSystem.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Employee : Window
    {

        public List<Bs_account> accountList { get; set; }
        public List<Bs_transaction> transactionList { get; set; }
        public List<Bs_user> userList { get; set; }
        public List<Bs_account> accountListBySotr { get; set; }

        public Employee()
        {

            InitializeComponent();

        }

        public Employee(int userId)
        {
            
            InitializeComponent();

            this.userId = userId;

            refreshAccounts();
            refreshUsers();

        }

        private int userId { get; set; }

        private void refreshAccounts()
        {

            this.accountList = Bs_account.GetList();
            Accounts.ItemsSource = this.accountList;

            if(this.accountList.Count != 0) { Accounts.SelectedIndex = 0; }

        }
        private void refreshAccountTransactions()
        {

            int srcId = -1;

            if(Accounts.SelectedIndex != -1) { srcId = ((Bs_account)Accounts.SelectedItem).id; }

            this.transactionList = Bs_transaction.GetList(srcId);

            Table.ItemsSource = this.transactionList;

        }

        private void refreshUsers()
        {

            this.userList = Bs_user.GetList(3);
            Users.ItemsSource = this.userList;

            if(this.userList.Count != 0) { Users.SelectedIndex = 0; }

        }

        private void refreshUserAccounts()
        {

            int srcId = -1;

            if(Users.SelectedIndex != -1) { srcId = ((Bs_user)Users.SelectedItem).id; }

            this.accountListBySotr = Bs_account.GetList(srcId);

            UserAccounts.ItemsSource = this.accountListBySotr;

        }

        private void Label_MouseUp(object sender, MouseButtonEventArgs e)
        {

            Page1.Visibility = Visibility.Visible;
            Page2.Visibility = Visibility.Hidden;

        }

        private void Label_MouseUp_1(object sender, MouseButtonEventArgs e)
        {

            Page1.Visibility = Visibility.Hidden;
            Page2.Visibility = Visibility.Visible;

        }

        private void Accounts_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            refreshAccountTransactions();

        }

        private void Users_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            refreshUserAccounts();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Bs_transaction selected = (Bs_transaction)Table.SelectedItem;

            if (selected == null) {

                Error error = new Error("Ошибка", "Не выбран счет для редактирования");
                error.ShowDialog();

                return;
            
            }

            double sum = selected.sum;
            int srcId = selected.bs_account_id_src;
            int distId = selected.bs_account_id_dist;

            Bs_account.Deposit(srcId, sum);
            Bs_account.Withdraw(distId, sum);
            Bs_transaction.Delete(selected.id);

            Success success = new Success("Отмена перевода", "Перевод успешно отменен. Баланс счетов скорректирован");
            success.ShowDialog();

            refreshAccounts();
            refreshAccountTransactions();

        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Bs_account selected = (Bs_account)UserAccounts.SelectedItem;

            if (selected == null)
            {

                Error error = new Error("Ошибка", "Не выбран счет для редактирования");
                error.ShowDialog();

                return;

            }

            _edit_Account account = new _edit_Account(selected);
            account.ShowDialog();

            refreshUsers();
            refreshUserAccounts();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            Bs_user selected = (Bs_user)Users.SelectedItem;

            if (selected == null)
            {

                Error error = new Error("Ошибка", "Не выбран пользователь для редактирования");
                error.ShowDialog();

                return;

            }

            _edit_User edit = new _edit_User(selected);
            edit.ShowDialog();

            refreshUsers();
            refreshUserAccounts();

        }

    }

}
