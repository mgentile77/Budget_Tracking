using System;

internal class Program{
    static void Main(
        string [] args
    ){
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
        }while(true);

    }
}