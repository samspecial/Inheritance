
using System;

namespace SavingAccountTask
{
  public class SavingsAccount
  {
    public static double annualInterestRate;
    private decimal savingBalance;

    public decimal SavingBalance
    {
      set
      {
        if (value > 0M)
        {
          savingBalance = value;
        }
      }
      get { return savingBalance; }
    }

    public SavingsAccount(decimal savingBalance)
    {
      SavingBalance = savingBalance;
    }

    public static double ModifyInterestRate
    {
      set
      {
        annualInterestRate = value / 100;
      }

      get { return annualInterestRate; }
    }
    public decimal CalculateMonthlyInterest()
    {
      return savingBalance * ((decimal)ModifyInterestRate / 12);
    }

    public decimal CurrentBalance()
    {
      decimal interest = CalculateMonthlyInterest();
      return interest + savingBalance;
    }
  }
}