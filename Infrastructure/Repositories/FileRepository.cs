using Application.Interfaces.Repositories;

namespace Infrastructure.Repositories;

//Using files for demonstration purposes only. For larger applications use a database instead
public class FileRepository : IFileRepository
{
    const string _path = "/Users/leonardo.gomes/RiderProjects/Teste/teste1.txt";
    public void SaveNotification(string informationToSave)
    {
        try
        {
            if (!File.Exists(_path))
            {
                File.Create(_path);
            }
            
            File.AppendAllText(_path, informationToSave + "\n");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public async Task<string[]> GetAllNotifications()
    {
        string[] lines = await File.ReadAllLinesAsync(_path);
        Array.Reverse(lines);
        return lines;
    }
}