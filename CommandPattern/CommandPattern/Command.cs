
using CommandPattern.Interfaces;

namespace CommandPattern
{
    public class Command : ICommand
    {
        public Command(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }

        public void Execute()
        {
            Console.WriteLine($"Comando executado: {this.Id} - {this.Name}");
        }
    }
}
