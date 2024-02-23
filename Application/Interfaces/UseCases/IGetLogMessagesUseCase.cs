namespace Application.Interfaces.UseCases;

public interface IGetLogMessagesUseCase
{
    public Task<string[]> GetLogMessages();
}