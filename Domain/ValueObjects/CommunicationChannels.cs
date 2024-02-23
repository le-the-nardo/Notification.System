namespace Domain.ValueObjects;

public class CommunicationChannels
{
    private List<string> _selectedChannels;

    public IReadOnlyList<string> SelectedChannels => _selectedChannels;

    public CommunicationChannels(List<string> selectedChannels)
    {
        ValidateChannels(selectedChannels);
        _selectedChannels = selectedChannels;
    }

    public void UpdateChannels(List<string> newChannels)
    {
        ValidateChannels(newChannels);
        _selectedChannels = newChannels;
    }

    private void ValidateChannels(List<string> channels)
    {
        // Lógica de validação, se necessário
        var validChannels = new List<string> { "SMS", "Email", "Push Notification" };
        foreach (var channel in channels)
        {
            if (!validChannels.Contains(channel))
            {
                throw new ArgumentException($"Canal de comunicação inválido: {channel}");
            }
        }
    }
}