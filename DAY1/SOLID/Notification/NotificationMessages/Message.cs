public class Message : INotificationMessage
{
    public string Message { get; set; }

    public string Recipient { get; set; }

    string Sender { get; set; }
}