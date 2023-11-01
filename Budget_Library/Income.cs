

namespace Budget_Library
{
    public class Income
    {
        public Decimal Value; 
        public List<string> Descriptions;

        public Income(string description, Decimal value)
        {
            string incomeList = $"{description}:        {value}";
            Descriptions.Add(incomeList);
            Value = value;
        }
    }
}
