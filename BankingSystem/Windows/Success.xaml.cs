using System.Windows;

namespace BankingSystem.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthFailed.xaml
    /// </summary>
    public partial class Success : Window
    {
        public Success()
        {
            InitializeComponent();
        }
        public Success(string title, string text)
        {

            InitializeComponent();
            this.Text.Text = text;
            this.Title = Title;

        }

        private void Grid_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            this.Close();

        }

    }

}
