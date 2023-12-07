

namespace Budget_Library
{
    public class Income
    {
        public decimal Value { get; private set; } 
        public string Description { get; private set; }

        public Income(string description, decimal value)
        {
            Description = description;
            Value = value;
        }
    }
}
