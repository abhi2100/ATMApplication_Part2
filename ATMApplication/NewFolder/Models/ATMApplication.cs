namespace ATMApplication.Models
{
    public class ATMApplication
    {
        private Bank _bank;

        public ATMApplication()
        {
            _bank = Bank.Instance;  // Access the Bank instance through the singleton pattern
        }

        // Other methods and properties
    }
}
