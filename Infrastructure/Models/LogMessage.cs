namespace Domain.Models;

public class LogMessage
{
    public int Id { get; set; }
    public string? Content { get; set; }
    public string? Category { get; set; }
    public string? Channel { get; set; }
    public string? UserInfo { get; set; }
    public DateTime Timestamp { get; set; }
}