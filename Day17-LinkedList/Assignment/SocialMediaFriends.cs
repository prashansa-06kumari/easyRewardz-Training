using System;
using System.Collections.Generic;

class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> FriendIds { get; set; }

    public User(int userId, string name, int age)
    {
        UserId = userId;
        Name = name;
        Age = age;
        FriendIds = new List<int>();
    }
}

class SocialMediaSystem
{
    private List<User> users = new List<User>();

    public void AddUser(User user)
    {
        users.Add(user);
    }

    private User FindUser(int userId)
    {
        foreach (User user in users)
        {
            if (user.UserId == userId)
                return user;
        }

        return null;
    }

    public void AddFriend(int userId1, int userId2)
    {
        User user1 = FindUser(userId1);
        User user2 = FindUser(userId2);

        if (user1 != null && user2 != null)
        {
            if (!user1.FriendIds.Contains(userId2))
                user1.FriendIds.Add(userId2);

            if (!user2.FriendIds.Contains(userId1))
                user2.FriendIds.Add(userId1);
        }
    }

    public void RemoveFriend(int userId1, int userId2)
    {
        User user1 = FindUser(userId1);
        User user2 = FindUser(userId2);

        user1?.FriendIds.Remove(userId2);
        user2?.FriendIds.Remove(userId1);
    }

    public void DisplayFriends(int userId)
    {
        User user = FindUser(userId);

        if (user == null)
            return;

        foreach (int friendId in user.FriendIds)
        {
            User friend = FindUser(friendId);

            if (friend != null)
                Console.WriteLine($"{friend.UserId} - {friend.Name}");
        }
    }

    public void FindMutualFriends(int userId1, int userId2)
    {
        User user1 = FindUser(userId1);
        User user2 = FindUser(userId2);

        if (user1 == null || user2 == null)
            return;

        foreach (int friendId in user1.FriendIds)
        {
            if (user2.FriendIds.Contains(friendId))
            {
                User friend = FindUser(friendId);
                Console.WriteLine(friend.Name);
            }
        }
    }

    public void SearchUser(string name)
    {
        foreach (User user in users)
        {
            if (user.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"{user.UserId} - {user.Name}");
        }
    }

    public void CountFriends()
    {
        foreach (User user in users)
        {
            Console.WriteLine(
                $"{user.Name}: {user.FriendIds.Count} friends");
        }
    }
}