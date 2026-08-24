using NUnit.Framework;

namespace SocialMediaTest1
{
    public class Tests
    {
        SocialMedia app;
        [SetUp]
        public void Setup()
        {
            app = new SocialMedia();

            app.AddUser(new UserProfile(1, "Ram"));
            app.AddUser(new UserProfile(2, "Shyam"));
            app.AddUser(new UserProfile(3, "Pk"));
        }

        
        [Test]
        public void FindUserTest()
        {
            UserProfile user = app.FindUser(1);
            Assert.That(user, Is.Not.Null);
            Assert.That(user.Username, Is.EqualTo("Ram"));
        }

        
        [Test]
        public void UserNotFoundTest()
        {
            UserProfile user = app.FindUser(99);

            Assert.That(user, Is.Null);
        }        
        [Test]
        public void AddStoryTest()
        {
            app.AddStory(
                new Story(1, 1, "Ram Story"));

            Assert.That( app.CurrentStory().Content,Is.EqualTo("Ram Story"));
        }
        [Test]
        public void NextStoryTest()
        {
            app.AddStory(new Story(1, 1, "Ram Story"));

            app.AddStory(new Story(2, 2, "Shyam Story"));
            Story story = app.NextStory();
            Assert.That(story.Id, Is.EqualTo(2));
        }
        [Test]
        public void StoryWrapAroundTest()
        {
            app.AddStory(new Story(1, 1, "Ram"));

            app.AddStory(new Story(2, 2, "Shyam"));

            app.NextStory();
            Story story = app.NextStory();
            Assert.That(story.Id, Is.EqualTo(1));
        }
       
        [Test]
        public void NoStoriesTest()
        {
            Assert.That( app.CurrentStory(),Is.Null);
        }
        [Test]
        public void AddPostTest()
        {
            app.AddPost(
                new FeedItem(101, 1,"Learning C#",10, 5));

            Assert.That(app.GetFeed().Count,Is.EqualTo(1));
        }
    }   
}