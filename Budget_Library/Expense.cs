namespace Budget_Library
{
    public class Expense
    {
        public List<string> Descriptions;
        public decimal Value;

        public Expense(string description, decimal value)
        {
            string expenseList = $"{description}:        {value}";
            Descriptions.Add(expenseList);
            Value = value;
        }
    }
}