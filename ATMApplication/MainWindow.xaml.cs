using System.Windows;

namespace ATMApplication
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            var createAccountWindow = new Createaccountwindow();
            createAccountWindow.Show();
            Close();
        }

        private void btnSelectAccount_Click(object sender, RoutedEventArgs e)
        {
            var selectAccountWindow = new SelectAccountWindow();
            selectAccountWindow.Show();
            Close();
        }
    }
}
