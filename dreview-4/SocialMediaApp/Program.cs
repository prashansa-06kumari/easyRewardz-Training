using System;
using System.Collections.Generic;
public class UserProfile
{
    public int Id;
    public string Username;
    public List<string> Followers = new List<string>();
    public UserProfile(int id, string username)
    {
        Id = id;
        Username = username;
    }
}
public class Story
{
    public int Id, UserId;
    public string Content;
    public Story(int id, int userId, string content)
    {
        Id = id;
        UserId = userId;
        Content = content;
    }
    public override string ToString()
    {
        return "Story " + Id + ": " + Content;
    }
}
public class FeedItem
{
    public int Id, UserId, Likes, Comments;
    public string Content;
    public DateTime CreatedAt;
    public int Engagement
    {
        get { return Likes + Comments; }
    }
    public FeedItem(int id, int userId, string content, int likes, int comments)
    {
        Id = id;
        UserId = userId;
        Content = content;
        Likes = likes;
        Comments = comments;
        CreatedAt = DateTime.Now;
    }
    public override string ToString()
    {
        return "Post " + Id + ": " + Content +" | Engagement: " + Engagement;
    }
}
public class Notification
{
    public int UserId;
    public string Message;
    public Notification(int userId, string message)
    {
        UserId = userId;
        Message = message;
    }
    public override string ToString()
    {
        return Message;
    }
}
public class StoryNode
{
    public Story Data;
    public StoryNode Next;
    public StoryNode Previous;
    public StoryNode(Story story)
    {
        Data = story;
    }
}
public class StoryList
{
    private StoryNode head;
    private StoryNode current;
    public void Add(Story story)
    {
        StoryNode node = new StoryNode(story);
        if (head == null)
        {
            head = current = node;
            node.Next = node;
            node.Previous = node;
        }
        else
        {
            StoryNode tail = head.Previous;

            node.Next = head;
            node.Previous =tail;
            tail.Next= node;
            head.Previous = node;
        }
    }
    public Story Current()
    {
        return current == null?null : current.Data;
    }
    public Story Next()
    {
        if (current == null) return null;

        current = current.Next;
        return current.Data;
    }
    public Story Previous()
    {
        if (current == null) return null;

        current = current.Previous;
        return current.Data;
    }
}
public class FeedNode
{
    public FeedItem Data;
    public FeedNode Next;
    public FeedNode(FeedItem item)
    {
        Data = item;
    }
}

public class FeedList
{
    private FeedNode head;
    private FeedNode tail;
    public void Add(FeedItem item)
    {
        FeedNode node = new FeedNode(item);
        if (head == null)
            head = tail = node;
        else
        {
            tail.Next = node;
            tail = node;
        }
    }
    public List<FeedItem> GetAll()
    {
        List<FeedItem> list = new List<FeedItem>();
        FeedNode current = head;
        while (current!= null)
        {
            list.Add(current.Data);
            current = current.Next;
        }
        return list;
    }
}
public class SocialMedia
{
    StoryList stories = new StoryList();
    FeedList feed = new FeedList();
    Stack<Story> history = new Stack<Story>();
    Queue<Notification> notifications =new Queue<Notification>();
    Dictionary<int, UserProfile> users = new Dictionary<int, UserProfile>();
    public void AddUser(UserProfile user)
    {
        users[user.Id] = user;
    }
    public UserProfile FindUser(int id)
    {
        if (users.ContainsKey(id))
            return users[id];

        return null;
    }
    public void AddStory(Story story)
    {
        if (users.ContainsKey(story.UserId))
            stories.Add(story);
    }
    public Story CurrentStory()
    {
        return stories.Current();
    }
    public Story NextStory()
    {
        return stories.Next();
    }
    public Story PreviousStory()
    {
        return stories.Previous();
    }
    public void OpenStory()
    {
        Story story = CurrentStory();

        if (story != null)
            history.Push(story);
    }
    public Story Back()
    {
        if (history.Count == 0)
            return null;

        history.Pop();

        if (history.Count == 0)
            return null;

        return history.Peek();
    }
    public void AddPost(FeedItem post)
    {
        if (users.ContainsKey(post.UserId))
            feed.Add(post);
    }
    public List<FeedItem> GetFeed()
    {
        return feed.GetAll();
    }

    public List<FeedItem> SortByEngagement()
    {
        List<FeedItem> list = feed.GetAll();
        list.Sort((a, b) =>
            b.Engagement.CompareTo(a.Engagement));

        return list;
    }
    public List<FeedItem> SortByRecency()
    {
        List<FeedItem> list = feed.GetAll();
        list.Sort((a, b) =>
            b.CreatedAt.CompareTo(a.CreatedAt));

        return list;
    }

    public void AddNotification(Notification n)
    {
        notifications.Enqueue(n);
    }
    public Notification GetNotification()
    {
        if (notifications.Count == 0)
            return null;

        return notifications.Dequeue();
    }

    public void AddFollower(int id, string username)
    {
        if (users.ContainsKey(id))
            users[id].Followers.Add(username);
    }
    public string SearchFollower(int id, string username)
    {
        if (!users.ContainsKey(id))
            return null;

        List<string> followers =users[id].Followers;
        followers.Sort();
        int left = 0;
        int right = followers.Count - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (followers[mid] == username)
                return followers[mid];
            if (followers[mid].CompareTo(username) < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }
}
public class Program
{
    static void Main()
    {
        SocialMedia app = new SocialMedia();

        app.AddUser(new UserProfile(1, "Ram"));
        app.AddUser(new UserProfile(2, "Shyam"));
        app.AddUser(new UserProfile(3, "Pk"));

      
        app.AddStory(new Story(1, 1, "Ram Story"));
        app.AddStory(new Story(2, 2, "Shyam Story"));
        app.AddStory(new Story(3, 3, "PK Story"));

        Console.WriteLine("STORIES");

        Console.WriteLine(app.CurrentStory());
        Console.WriteLine(app.NextStory());
        Console.WriteLine(app.NextStory());

      
        Console.WriteLine(app.NextStory());
        Console.WriteLine("\n BACK ");

        app.OpenStory();
        app.NextStory();
        app.OpenStory();

        Console.WriteLine(app.Back());

        app.AddPost(new FeedItem(
            101, 1, "Learning C#", 100, 20));

        app.AddPost(new FeedItem(
            102, 2, "Review 4", 200, 30));

        app.AddPost(new FeedItem(
            103, 3, "DSA Test", 50, 10));

        Console.WriteLine("\n FEED ");

        foreach (FeedItem post in app.GetFeed())
            Console.WriteLine(post);

        Console.WriteLine("\n ENGAGEMENT ");

        foreach (FeedItem post in app.SortByEngagement())
            Console.WriteLine(post);

       
        Console.WriteLine("\n RECENCY ");

        foreach (FeedItem post in app.SortByRecency())
            Console.WriteLine(post);

        app.AddNotification(
            new Notification(1, "Ram liked your post"));

        app.AddNotification(
            new Notification(1, "PK followed you"));

        Console.WriteLine("\n NOTIFICATIONS ");

        Console.WriteLine(app.GetNotification());
        Console.WriteLine(app.GetNotification());

        app.AddFollower(1, "Ram");
        app.AddFollower(1, "PK");
        app.AddFollower(1, "Jeet");

        Console.WriteLine("\n SEARCH ");

        string result = app.SearchFollower(1, "PK");

        Console.WriteLine(result == null ? "Follower not found": "Found: " + result);

        Console.WriteLine("\n USER ");

        UserProfile user = app.FindUser(99);

        Console.WriteLine(user == null? "User not found": user.Username);
        SocialMedia empty = new SocialMedia();

        Console.WriteLine("\n EDGE CASES");

        Console.WriteLine(empty.CurrentStory() == null? "No stories": "Story exists");

        Console.WriteLine(empty.GetNotification() == null ? "No notifications": "Notification exists");

        Console.WriteLine(empty.GetFeed().Count == 0? "Feed is empty" : "Feed has posts");
    }
}