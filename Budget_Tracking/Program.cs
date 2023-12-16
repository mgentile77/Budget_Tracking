using Budget_Library;
using System;

internal class Program{
    static void Main(
        string [] args
    ){
        Budget budget = new Budget(new Csvrepository());
        do{
            Console.WriteLine();
            Console.WriteLine("Busget Tracking Application");
            Console.WriteLine("Add Income = 1");
            Console.WriteLine("Add Expense = 2");
            Console.WriteLine("View Report = 3");
            Console.WriteLine("Delete Income Entry = 4");
            Console.WriteLine("Delete Expense Entry = 5");
            Console.WriteLine("Exit Program = 0");
            Console.Write("Choose your option: ");
            var entry = Console.ReadLine();
            if (Convert.ToInt32(entry) == 0)
                break;
            if (Convert.ToInt32(entry) == 1)
            {
                do{
                    Console.WriteLine("Enter Type of Income: ");
                    var Description = Console.ReadLine();
                    Console.WriteLine("Enter Your Income: ");
                    var value = Convert.ToDecimal(Console.ReadLine());
                    Income income = new Income(Description, value);
                    budget.Add_Income(income);
                    break;
                } while (true);
            }
            if (Convert.ToInt32(entry) == 2)
            {
                do
                {
                    Console.WriteLine("Enter Type of Expense: ");
                    var Description = Console.ReadLine();
                    Console.WriteLine("Enter Your Expense: ");
                    var value = Convert.ToDecimal(Console.ReadLine());
                    Expense expense = new Expense(Description, value);
                    budget.Add_Expense(expense);
                    break;
                } while (true);
            }
            if (Convert.ToInt32(entry) == 3)
            {
                Console.WriteLine(budget.incomes.IncomeDescriptions());
                Console.WriteLine(budget.expenses.ExpenseDescriptions());
                Console.WriteLine(Reports.BalanceSheet(budget.incomes, budget.expenses));
            }
            if (Convert.ToInt32(entry) == 4)
            {
                do
                {
                    Console.WriteLine(budget.incomes.IncomeDescriptions());
                    Console.WriteLine("Enter Line Number of Income to Remove: ");
                    int indexChosen = Convert.ToInt32(Console.ReadLine());
                    budget.Delete_Income(indexChosen);
                    break;
                } while (true);
            }
            if (Convert.ToInt32(entry) == 5)
            {
                do
                {
                    Console.WriteLine(budget.expenses.ExpenseDescriptions());
                    Console.WriteLine("Enter Line Number of Income to Remove: ");
                    int indexChosen = Convert.ToInt32(Console.ReadLine());
                    budget.Delete_Expense(indexChosen);
                    break;
                } while (true);
            }
        } while (true);

    }
}