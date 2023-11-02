using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Budget_Library
{
    public class Reports
    {
        private List<Expense> expenses;
        private List<Income> incomes;

        public Reports(List<Expense> expenses, List<Income> incomes)
        {
            this.expenses = expenses;
            this.incomes = incomes;
        }

        public string IncomeDescriptions()
        {
            string incomeDetail = "";
            foreach (var income in incomes)
            {
                incomeDetail = incomeDetail + $"{income.Descriptions}:   {income.Value}";
            }
            return incomeDetail;
        }
        public decimal IncomeTotal()
        {
            return incomes.Select(i => i.Value).Sum();
        }
        public string ExpenseDescriptions()
        {
            string expenseDetail = "";
            foreach (var expense in expenses)
            {
                expenseDetail = expenseDetail + $"{expense.Descriptions}:   {expense.Value}";
            }
            return expenseDetail;
        }
        public decimal ExpenseTotal()
        {
            return expenses.Select(i => i.Value).Sum();
        }
        public string BalanceSheet()
        {
            decimal sheetTotal = IncomeTotal() - ExpenseTotal();
            if (sheetTotal < 0)
            {
                return $"You currently show a loss of:\t{sheetTotal}";
            }
            return $"Your current profit is:\t {sheetTotal}";
        }
    }
}
