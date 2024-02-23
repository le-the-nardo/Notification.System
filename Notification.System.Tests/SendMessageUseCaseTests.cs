using Application.Interfaces;
using Application.Interfaces.Repositories;
using Application.UseCases;
using Moq;

namespace Notification.System.Tests;

public class SendMessageUseCaseTests
{
    [Fact]
    public void SendMessage_SuccessfulOperation()
    {
        // Arrange
        var fileRepositoryMock = new Mock<IFileRepository>();
        var notificationServiceMock = new Mock<INotificationService>();

        var useCase = new SendMessageUseCase(fileRepositoryMock.Object, notificationServiceMock.Object);

        // Act
        var result = useCase.SendMessage("Test Content", "Test Category");

        // Assert
        Assert.Equal("Operation succeeded", result);
    }
}