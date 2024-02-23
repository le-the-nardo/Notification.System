namespace Application.Interfaces.UseCases;

public interface ISendMessageUseCase
{
    public string SendMessage(string content, string category);
}