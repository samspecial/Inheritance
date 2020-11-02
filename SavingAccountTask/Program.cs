using System;

namespace SavingAccountTask
{
  class Program
  {
    static void Main(string[] args)
    {
      SavingsAccount saverOne = new SavingsAccount(2000);
      SavingsAccount saverTwo = new SavingsAccount(3000);

      SavingsAccount.ModifyInterestRate = 4;


      Console.WriteLine($"Saver One Monthly Interest is: {saverOne.CalculateMonthlyInterest():0.00}");
      Console.WriteLine($"Saver Two Monthly Interest is: {saverTwo.CalculateMonthlyInterest():0.00}");
      Console.WriteLine($"Saver One current Balance is: {saverOne.CurrentBalance():0.00}");
      Console.WriteLine($"Saver Two current Balance {saverTwo.CurrentBalance():0.00}\n");
      Console.WriteLine("Interest Rate of 6% on Next Month Savings");

      SavingsAccount.ModifyInterestRate = 6;

      Console.WriteLine($"Saver One Monthly Interest is: {saverOne.CalculateMonthlyInterest():0.00}");
      Console.WriteLine($"Saver Two Monthly Interest is: {saverTwo.CalculateMonthlyInterest():0.00}");
      Console.WriteLine($"Saver One current Balance is: {saverOne.CurrentBalance():0.00}");
      Console.WriteLine($"Saver Two current Balance {saverTwo.CurrentBalance():0.00}");
    }
  }
}
