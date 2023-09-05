using CommandPattern.Interfaces;

namespace CommandPattern
{
    public class State : IState
    {
        public State(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public int StatusCode { get; private set; }
        public string Message { get; private set; }
    }
}
