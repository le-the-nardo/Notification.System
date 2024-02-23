using Application.Interfaces.Repositories;
using Application.Interfaces.UseCases;

namespace Application.UseCases;

public class GetLogMessagesUseCase : IGetLogMessagesUseCase
{
    private readonly IFileRepository _fileRepository;

    public GetLogMessagesUseCase(IFileRepository fileRepository)
    {
        _fileRepository = fileRepository;
    }
    
    public async Task<string[]> GetLogMessages()
    {
        return await _fileRepository.GetAllNotifications();
    }
}