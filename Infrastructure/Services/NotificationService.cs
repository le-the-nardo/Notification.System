using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Services;

public class NotificationService : INotificationService
{
    public void NotifyUser(Message message, User user)
    {
        foreach (var channel in user.Channels)
        {
            switch (channel)
            {
                case "Sms":
                    Console.WriteLine($"Sending SMS message: {message.Content}");
                    break;

                case "Email":
                    Console.WriteLine($"Sending e-mail message: {message.Content}");
                    break;

                case "Push notification":
                    Console.WriteLine($"Sending push notification message: {message.Content}");
                    break;

                default:
                    Console.WriteLine($"Channel not available.");
                    break;
            }
        }
    }
}