namespace Application.Interfaces.Repositories;

public interface IFileRepository
{
    public void SaveNotification(string informationToSave);
    public Task<string> GetAllNotifications();
}