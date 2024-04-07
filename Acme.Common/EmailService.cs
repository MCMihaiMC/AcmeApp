namespace Acme.Common
{
    public class EmailService
    {
        public string SendMessage(string subject, string message, string Email)
        {
            var messageSent = "Message sent " + DateTime.Now + ": " + message;
            LoggingService.LogAction("Message sent " + DateTime.Now + ": " + message);
            return messageSent;
        }
    }
}
