using System.Windows;
using ATMApplication.Models;

namespace ATMApplication
{
    public partial class SelectAccountWindow : Window
    {
        public SelectAccountWindow()
        {
            InitializeComponent();
        }

        private void btnSelectAccount_Click(object sender, RoutedEventArgs e)
        {
            string accountNumber = txtAccountNumber.Text;
            var account = Bank.Instance.GetAccount(accountNumber);

            if (account != null)
            {
                var accountMenuWindow = new AccountMenuWindow(account);
                accountMenuWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Account number not found.");
            }
        }
    }
}
