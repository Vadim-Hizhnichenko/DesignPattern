using Memento;

var ba = new BankAccount(100);
var m1 = ba.Deposit(50);
var m2 = ba.Deposit(25);
Console.WriteLine(ba); // 175

// restore to m1
ba.Restore(m1);
Console.WriteLine(ba); // 150

// restore to m2
ba.Restore(m2);
Console.WriteLine(ba); // 175