using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class InsertClientCommand : ICommand
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
