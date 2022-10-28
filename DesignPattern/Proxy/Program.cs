using Proxy.DinamycProxy;
using Proxy.ProtectionProxy;
using Proxy.Virtual;

ICar car = new CarProxy(new Driver(12)); // 22
car.Drive();

 void DrawImage(IImage img)
{
    Console.WriteLine("About to draw the image");
    img.Draw();
    Console.WriteLine("Done drawing the image");
}

var img = new LazyBitmap("pokemon.png");
DrawImage(img);

//var ba = new BankAccount();
var ba = Log<BankAccount>.As<IBankAccount>();

ba.Deposit(100);
ba.Withdraw(50);

Console.WriteLine(ba);
