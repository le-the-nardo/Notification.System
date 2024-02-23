using Application.Interfaces;
using Application.Interfaces.Repositories;
using Application.Interfaces.UseCases;
using Domain.Entities;
using Domain.EntitiesMocks;

namespace Application.UseCases;

public class SendMessageUseCase : ISendMessageUseCase
{
    private readonly IFileRepository _fileRepository;
    private readonly INotificationService _notificationService;

    public SendMessageUseCase(IFileRepository fileRepository, INotificationService notificationRepository)
    {
        _fileRepository = fileRepository;
        _notificationService = notificationRepository;
    }

    public string SendMessage(string content, string categoryMessage)
    {
        //validate fields
        if (string.IsNullOrEmpty(content) || string.IsNullOrEmpty(categoryMessage))
        {
            throw new Exception("Incorrect request values");
        }

        var category = Mocks.GetMockCategories().Find((c) => c.Name!.Equals(categoryMessage));

        //Get message
        var message = new Message
        {
            Id = Guid.NewGuid(),
            Content = content,
            Category = category
        };

        //Get mocks
        var userList = Mocks.GenerateMockUserList();
        var usersToNotify = new List<User>();

        //Verify which users are registered in category
        foreach (var user in userList)
        {
            if (user.SubscribedCategories.Contains(category!))
            {
                usersToNotify.Add(user);
            }
        }

        //Notify Users
        foreach (var userToNotify in usersToNotify)
        {
            _notificationService.NotifyUser(message, userToNotify);
            //Persist the notification in a file 
            _fileRepository.SaveNotification(
                $"MessageId: {message.Id} - UserId: {userToNotify.Id} - Category message: {message.Category!.Name} - At: {DateTime.Now}");
        }


        return "Sucesso";
    }
}