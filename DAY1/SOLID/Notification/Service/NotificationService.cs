public class NotificationService
{
    private INotificationChannel channel;

    public NotificationService(INotificationChannel channel, INotificationMessage message)
    {
        this.channel = channel;
        this.message = message;
    }

    public void SendNotification()
    {
        channel.SendNotification(message);
    }
}