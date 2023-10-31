using Budget_Library;
using System;

internal class Program{
    static void Main(
        string [] args
    ){
        Budget budget = new Budget();
        do{
            Console.WriteLine();
            Console.WriteLine("Busget Tracking Application");
            Console.WriteLine("Add Income = 1");
            Console.WriteLine("Add Expense = 2");
            Console.WriteLine("View Report = 3");
            Console.WriteLine("Exit Program = 0");
            Console.Write("Choose your option: ");
            var entry = Console.ReadLine();
            if (Convert.ToInt32(entry) == 0)
                break;
            if (Convert.ToInt32(entry) == 1)
            {
                do {
                    Console.WriteLine("Enter Type of Income: ");
                    var Description = Console.ReadLine();
                    Console.WriteLine("Enter Your Income: ");
                    var value =Convert.ToDecimal(Console.ReadLine());
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
        } while(true);

    }
}