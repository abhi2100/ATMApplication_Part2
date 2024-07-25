namespace ATMApplication.Models
{
    public class Transaction
    {
        public string Type { get; }
        public double Amount { get; }

        public Transaction(string type, double amount)
        {
            Type = type;
            Amount = amount;
        }
    }
}
