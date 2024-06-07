namespace AutotestAPI.Framework
{
    public class Sender
    {
        public string Name { get; set; }
        public string Message { get; set; }

        public Sender(string _name, string _message)
        {
            Name = _name;
            Message = _message;
        }
    }
}
