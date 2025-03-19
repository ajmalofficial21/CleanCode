public interface INotificationChannel
{
    void SendNotification(INotificationMessage message);
}