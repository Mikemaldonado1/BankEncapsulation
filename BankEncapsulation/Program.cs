
using BankEncapsulation;

BankAccount myAccount = new BankAccount();

myAccount.Deposit(500);

var myBalance = myAccount.GetBalance();

Console.WriteLine($"Your new balance is ${myBalance}");

