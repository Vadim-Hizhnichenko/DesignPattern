namespace Adapter
{
    public class OpenCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Opening a file");
        }
    }
}
