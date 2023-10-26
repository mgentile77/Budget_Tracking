

using System.Collections.Generic;

namespace Budget_Library
{
    public class Budget
    {
        public List<Income> incomes = new List<Income>();
        public List<Expense> expenses = new List<Expense>();

        public void Add_Expense(Expense expense)
        {
            expenses.Add(expense);
        }
        public void Add_Income(Income income)
        {
            incomes.Add(income);
        }
    }

}
