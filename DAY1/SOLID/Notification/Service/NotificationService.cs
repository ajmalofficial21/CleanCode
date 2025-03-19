public class NotificationService
{
    private INotificationChannel channel;
    private INotificationMessage message;

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