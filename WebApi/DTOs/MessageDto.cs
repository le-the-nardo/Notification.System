using System.Text.Json.Serialization;

namespace WebApi.DTOs;

public class MessageDto
{
    [JsonPropertyName("content")]
    public string? Content { get; set; }
    [JsonPropertyName("category")]
    public string? Category { get; set; }
}