using System.Windows;
using ATMApplication.Models;

namespace ATMApplication
{
    public partial class Createaccountwindow : Window
    {
        public Createaccountwindow()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            string accountNumber = txtAccountNumber.Text;
            string accountHolderName = txtAccountHolderName.Text;
            double initialDeposit = double.Parse(txtInitialDeposit.Text);
            double interestRate = double.Parse(txtInterestRate.Text);

            Bank.Instance.CreateAccount(accountNumber, accountHolderName, initialDeposit, interestRate);

            MessageBox.Show("Account created successfully!");

            var mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
