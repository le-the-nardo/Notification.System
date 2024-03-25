using Application.Interfaces;
using Application.Interfaces.Repositories;
using Application.UseCases;

namespace Notification.System.Tests;

[TestClass]
public class SendMessageUseCaseTests
{
    [TestMethod]
    public void SendMessage_SuccessfulOperation()
    {
        // Arrange
        var fileRepositoryMock =  A.Fake<IFileRepository>();
        var notificationServiceMock = A.Fake<INotificationService>();

        var useCase = new SendMessageUseCase(fileRepositoryMock, notificationServiceMock);

        // Act
        var result = useCase.SendMessage("Test Content", "Test Category");

        // Assert
        result.Should().Be("Operation succeeded");
    }
}