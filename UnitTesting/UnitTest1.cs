using AutoFixture;
using Budget_Library;
using FluentAssertions;
using NSubstitute;
using NSubstitute.Extensions;

namespace UnitTesting
{
    public class BudgetTest
    {
        private readonly ICSVRepository mockCsvRepository;
        private Fixture fixture;

        public BudgetTest()
        {
            mockCsvRepository = Substitute.For<ICSVRepository>();
            fixture = new Fixture();
        }
        [Fact]
        public void Add_Expense_AddSingeleExpense_ShouldAddToListofExpenses()
        {
            // Arrange
            var incomes = fixture.CreateMany<Income>(3).ToList();
            var expenses = fixture.CreateMany<Expense>(3).ToList();
            mockCsvRepository.Csv_read<Income>(Arg.Any<string>()).Returns(incomes);
            mockCsvRepository.Csv_read<Expense>(Arg.Any<string>()).Returns(expenses);
            mockCsvRepository.savecsv<Expense>(Arg.Any<List<Expense>>(), Arg.Any<string>());
            var budget = new Budget(mockCsvRepository);

            // Act
            budget.Add_Expense(new Expense ( "christmas dog", 500M ));

            // Assert
            mockCsvRepository.Received(1).savecsv<Expense>(Arg.Any<List<Expense>>(), Arg.Any<string>());
            budget.expenses.Should().HaveCount(4);
        }
        [Fact]
        public void Add_Income_AddSingeleIncome_ShouldAddToListofIncomes()
        {
            // Arrange
            var incomes = fixture.CreateMany<Income>(3).ToList();
            var expenses = fixture.CreateMany<Expense>(3).ToList();
            mockCsvRepository.Csv_read<Income>(Arg.Any<string>()).Returns(incomes);
            mockCsvRepository.Csv_read<Expense>(Arg.Any<string>()).Returns(expenses);
            mockCsvRepository.savecsv<Income>(Arg.Any<List<Income>>(), Arg.Any<string>());
            var budget = new Budget(mockCsvRepository);

            // Act
            budget.Add_Income(new Income("Holiday Bonus", 1500.00M));

            // Assert
            mockCsvRepository.Received(1).savecsv<Income>(Arg.Any<List<Income>>(), Arg.Any<string>());
            budget.incomes.Should().HaveCount(4);
        }
        [Fact]
        public void Remove_Expense_RemoveSingeleExpense_ShouldRemoveFromListofExpenses()
        {
            // Arrange
            var incomes = fixture.CreateMany<Income>(3).ToList();
            var expenses = fixture.CreateMany<Expense>(3).ToList();
            mockCsvRepository.Csv_read<Income>(Arg.Any<string>()).Returns(incomes);
            mockCsvRepository.Csv_read<Expense>(Arg.Any<string>()).Returns(expenses);
            mockCsvRepository.savecsv<Expense>(Arg.Any<List<Expense>>(), Arg.Any<string>());
            var budget = new Budget(mockCsvRepository);

            // Act
            budget.Delete_Expense(1);

            // Assert
            mockCsvRepository.Received(1).removecsv<Expense>(Arg.Any<List<Expense>>(), Arg.Any<string>());
            budget.expenses.Should().HaveCount(2);
        }
        [Fact]
        public void Remove_Income_RemoveSingeleIncome_ShouldRemoveFromListofIncomes()
        {
            // Arrange
            var incomes = fixture.CreateMany<Income>(3).ToList();
            var expenses = fixture.CreateMany<Expense>(3).ToList();
            mockCsvRepository.Csv_read<Income>(Arg.Any<string>()).Returns(incomes);
            mockCsvRepository.Csv_read<Expense>(Arg.Any<string>()).Returns(expenses);
            mockCsvRepository.savecsv<Income>(Arg.Any<List<Income>>(), Arg.Any<string>());
            var budget = new Budget(mockCsvRepository);

            // Act
            budget.Delete_Income(1);

            // Assert
            mockCsvRepository.Received(1).removecsv<Income>(Arg.Any<List<Income>>(), Arg.Any<string>());
            budget.incomes.Should().HaveCount(2);
        }
    }
}