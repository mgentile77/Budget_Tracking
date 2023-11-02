

namespace Budget_Library
{
    public class Income
    {
        public decimal Value { get; private set; } 
        public string Descriptions { get; private set; }

        public Income(string description, decimal value)
        {
            Descriptions = description;
            Value = value;
        }
    }
}
