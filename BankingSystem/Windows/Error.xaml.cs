using System.Windows;

namespace BankingSystem.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthFailed.xaml
    /// </summary>
    public partial class Error : Window
    {
        public Error()
        {
            InitializeComponent();
        }
        public Error(string title, string text)
        {

            InitializeComponent();
            this.Text.Text = text;
            this.Title = title;

        }

        private void Grid_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            this.Close();

        }

    }

}
