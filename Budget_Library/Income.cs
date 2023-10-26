

namespace Budget_Library
{
    public class Income
    {
        public string Description { get; private set; }
        public decimal Value { get; private set; }

        public Income(string description, decimal value)
        {
            Description = description;
            Value = value;
        }
    }
}
