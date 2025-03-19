public interface INotificationMessage
{
    string Message { get; set; }

    string Sender { get; set; }

    string Recipient { get; set; }
}