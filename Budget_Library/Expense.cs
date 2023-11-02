namespace Budget_Library
{
    public class Expense
    {
        public string Descriptions { get; private set; }
        public decimal Value { get; private set; }

        public Expense(string description, decimal value)
        {
            Descriptions = description;
            Value = value;
        }
    }
}