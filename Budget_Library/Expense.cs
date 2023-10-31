namespace Budget_Library
{
    public class Expense
    {
        public string Description {get; private set;}
        public decimal Value { get; private set;}

        public Expense(string description, decimal value)
        {
            Description = description;
            Value = value;
        }
    }
}