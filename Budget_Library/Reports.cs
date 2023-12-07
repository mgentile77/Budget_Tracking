using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Budget_Library
{
    public static class Reports
    {

        public static string IncomeDescriptions(this List<Income> incomes)
        {
            
            string incomeDetail = "";
            for (int i = 0; i < incomes.Count; i++)
            {
                incomeDetail = incomeDetail + $"{i}. {incomes[i].Description}:   {incomes[i].Value}\n";
            }
            incomeDetail = incomeDetail + $"Your income = ${incomes.IncomeTotal()}\n";
            return incomeDetail;
        }
        public static decimal IncomeTotal(this List<Income> incomes)
        {
            return incomes.Select(i => i.Value).Sum();
        }
        public static string ExpenseDescriptions(this List<Expense> expenses)
        {
            string expenseDetail = "";
            for (int i = 0; i < expenses.Count; i++)
            {
                expenseDetail = expenseDetail + $"{i}. {expenses[i].Description}:   -{expenses[i].Value}\n";
            }
            expenseDetail = expenseDetail + $"Your expenses = $-{expenses.ExpenseTotal()}\n";
            return expenseDetail;
        }
        public static decimal ExpenseTotal(this List<Expense> expenses)
        {
            return expenses.Select(i => i.Value).Sum();
        }
        public static string BalanceSheet(List<Income> incomes, List<Expense> expenses)
        {
            decimal sheetTotal = incomes.IncomeTotal() - expenses.ExpenseTotal();
            if (sheetTotal < 0)
            {
                return $"You currently show a loss of:\t{sheetTotal}";
            }
            return $"Your current profit is:\t {sheetTotal}";
        }
    }
}
