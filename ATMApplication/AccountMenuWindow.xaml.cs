using System.Linq;
using System.Windows;
using ATMApplication.Models;

namespace ATMApplication
{
    public partial class AccountMenuWindow : Window
    {
        private Account _account;

        public AccountMenuWindow(Account account)
        {
            InitializeComponent();
            _account = account;
        }

        private void btnCheckBalance_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Current balance: {_account.Balance}");
        }

        private void btnDeposit_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtAmount.Text, out double amount))
            {
                MessageBox.Show("Invalid amount.");
                return;
            }

            _account.Deposit(amount);
            MessageBox.Show($"Deposited {amount}. Current balance: {_account.Balance}");
        }

        private void btnWithdraw_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtAmountWithdraw.Text, out double amount))
            {
                MessageBox.Show("Invalid amount.");
                return;
            }

            try
            {
                _account.Withdraw(amount);
                MessageBox.Show($"Withdrew {amount}. Current balance: {_account.Balance}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplayTransactions_Click(object sender, RoutedEventArgs e)
        {
            var transactions = _account.GetTransactions();
            var transactionsInfo = $"Account holder name: {_account.AccountHolderName}\n" +
                                    $"Initial deposit: {_account.InitialDeposit}\n" +
                                    $"Deposits and Withdrawals:\n" +
                                    string.Join("\n", transactions.Select(t => $"{t.Type}: {t.Amount}")) + "\n" +
                                    $"Balance left: {_account.Balance}";

            txtTransactions.Text = transactionsInfo;
        }

        private void btnExitAccount_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
