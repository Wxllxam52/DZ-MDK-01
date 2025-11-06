using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class BankAccount
    {
        public string AccountNumber { get; }
        public string Owner { get; }
        public decimal Balance { get; protected set; }

        public BankAccount(string accountNumber, string owner, decimal balance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Счет: {AccountNumber}");
            Console.WriteLine($"Владелец: {Owner}");
            Console.WriteLine($"Баланс: {Balance}");
        }
    }

    class CheckingAccount : BankAccount
    {
        public decimal OverdraftLimit { get; }

        public CheckingAccount(string accountNumber, string owner, decimal balance, decimal overdraftLimit) : base(accountNumber, owner, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Лимит овердрафта: {OverdraftLimit}");
        }
    }

    class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; }

        public SavingsAccount(string accountNumber, string owner, decimal balance, decimal interestRate) : base(accountNumber, owner, balance)
        {
            InterestRate = interestRate;
        }

        public void AddInterest()
        {
            decimal interest = Balance * InterestRate / 100;
            Balance += interest;
            Console.WriteLine($"Начислены проценты: {interest} руб. Новый баланс: {Balance}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Процентная ставка: {InterestRate}%");
        }
    }

    class CreditAccount : BankAccount
    {
        public decimal CreditLimit { get; }
        public string RepaymentDate { get; }

        public CreditAccount(string accountNumber, string owner, decimal balance, decimal creditLimit, string repaymentDate) : base(accountNumber, owner, balance)
        {
            CreditLimit = creditLimit;
            RepaymentDate = repaymentDate;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Кредитный лимит: {CreditLimit}");
            Console.WriteLine($"Срок погашения: {RepaymentDate}");
        }
    }
}
