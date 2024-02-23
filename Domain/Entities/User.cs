namespace Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public List<Category> SubscribedCategories { get; set; } = [];
    public List<string> Channels { get; set; } = [];

    public void SubscribeToCategory(Category category)
    {
        if (!SubscribedCategories.Contains(category))
        {
            SubscribedCategories.Add(category);
        }
    }
    
    public void UnsubscribeFromCategory(Category category)
    {
        SubscribedCategories.Remove(category);
    }
}