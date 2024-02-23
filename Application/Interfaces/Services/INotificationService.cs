using Domain.Entities;

namespace Application.Interfaces;

public interface INotificationService
{
    public void NotifyUser(Message message, User user);
}