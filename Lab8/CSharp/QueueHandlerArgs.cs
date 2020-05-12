namespace CSharp
{
    public class QueueHandlerArgs
    {
        private string _message;
        private object _sender;

        public string Message => _message;
        public object Sender => _sender;

        public QueueHandlerArgs(string message, object sender)
        {
            _message = message;
            _sender = sender;
        }
    }
}