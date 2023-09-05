namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var receiver = new Receiver();
            var commandState = (State) receiver.Handle(new Command(1, "Commando 1"));

            Console.WriteLine($"{commandState.StatusCode} - {commandState.Message}");
        }
    }
}