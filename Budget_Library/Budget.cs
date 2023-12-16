

using System.Collections.Generic;

namespace Budget_Library
{
    public class Budget
    {
        public List<Income> incomes = new List<Income>();
        public List<Expense> expenses = new List<Expense>();
        private readonly ICSVRepository Csvrepository;

        public Budget(ICSVRepository Csvrepository)
        {
            incomes = Csvrepository.Csv_read<Income>("incomeFile");
            expenses = Csvrepository.Csv_read<Expense>("expenseFile");
            this.Csvrepository = Csvrepository;
        }

        public void Add_Expense(Expense expense)
        {
            expenses.Add(expense);
            Csvrepository.savecsv(new List<Expense> {expense}, "expenseFile");
        }
        public void Add_Income(Income income)
        {
            incomes.Add(income);
            Csvrepository.savecsv(new List<Income> {income}, "incomeFile");
        }

        public void Delete_Expense(int indexChosen)
        {
            expenses.Remove(expenses[indexChosen]);
            Csvrepository.removecsv(expenses, "expenseFile");
        }

        public void Delete_Income(int indexChosen)
        {
            incomes.Remove(incomes[indexChosen]);
            Csvrepository.removecsv(incomes, "incomeFile");
        }
    }

}
