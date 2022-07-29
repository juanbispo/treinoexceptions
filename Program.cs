
using TreinamentoExceptions.Models;
using TreinamentoExceptions.Models.Exceptions;

try { 
    Console.WriteLine("Enter Account Data: ");

    Console.Write("Account Number: ");
    int numberAcc = int.Parse(Console.ReadLine());

    Console.Write("Holder: ");
    string nameTitular = Console.ReadLine();

    Console.Write("Initial Balance: ");

    double balance = double.Parse(Console.ReadLine());

    Console.Write("Withraw Limit: ");

    double limit = double.Parse(Console.ReadLine());

    var acc = new Account(numberAcc,nameTitular,balance,limit);

    Console.Write("Enter amount for withdraw: ");

    double withdraw = double.Parse(Console.ReadLine());

    acc.Withdraw(withdraw);

    Console.WriteLine("New Balance: " + acc.Balance);
}
catch(AccountException e)
{
    Console.WriteLine("Withdraw Error: "+ e.Message);
}
catch(Exception e)
{
    Console.WriteLine("Error! contact Support -> 1799717-7887");
}