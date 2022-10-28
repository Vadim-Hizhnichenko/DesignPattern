using Command;

var ba = new BankAccount();
var cmd = new BankAccountCommand(ba,
  BankAccountCommand.Action.Deposit, 100);
cmd.Call();
Console.WriteLine(ba);



var commands = new List<BankAccountCommand>
      {
        new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100),
        new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 1000)
      };

Console.WriteLine(ba);

foreach (var c in commands)
    c.Call();

Console.WriteLine(ba);

foreach (var c in Enumerable.Reverse(commands))
    c.Undo();

Console.WriteLine(ba);
