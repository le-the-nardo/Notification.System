namespace Domain.Entities;

public class Message
{
    public Guid Id { get; set; }
    public string? Content { get; set; }
    public Category? Category { get; set; }
}