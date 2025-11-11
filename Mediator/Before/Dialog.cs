namespace Mediator.Before
{
    internal class Dialog : IDialog
    {
        public void Show(string message)
        {
            Console.WriteLine($"Dialog Message:{message}");
        }
    }
}
