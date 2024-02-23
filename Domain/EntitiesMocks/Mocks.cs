using Domain.Entities;

namespace Domain.EntitiesMocks;

public static class Mocks
{
    private static List<Category> _mockedCategories =
    [
        new Category { Id = 1, Name = "Sports" },
        new Category { Id = 2, Name = "Finance" },
        new Category { Id = 3, Name = "Movies" }
    ];

    public static List<User> GenerateMockUserList()
    {
        var userList = new List<User>();
        var random = new Random();
        
        const int totalUsers = 3;
        for (var i = 0; i < totalUsers; i++)
        {
            var user = new User
            {
                Id = random.Next(1, 1000),
                Name = $"User{random.Next(1, 100)}",
                Email = $"user{random.Next(1, 100)}@example.com",
                Phone = $"123-456-{random.Next(1000, 9999)}",
                SubscribedCategories = [GetRandomMockCategories(random.Next(0, _mockedCategories.Count))],
                Channels = GenerateMockChannels()
            };
            userList.Add(user);
        }

        return userList;
    }

    public static List<Category> GetMockCategories()
    {
        return _mockedCategories;
    }
    
    private static Category GetRandomMockCategories(int index)
    {
        return _mockedCategories.ElementAt(index);
    }

    private static List<string> GenerateMockChannels()
    {
        var channels = new List<string>
        {
            "Sms",
            "Email",
            "Push notification"
        };

        return channels;
    }
}