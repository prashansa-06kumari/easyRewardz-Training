using System;

namespace Practice
{
    // Book -> Author

    class Book
    {
        protected string title;
        protected int publicationYear;

        public Book(string title, int publicationYear)
        {
            this.title = title;
            this.publicationYear = publicationYear;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title            : {title}");
            Console.WriteLine($"Publication Year : {publicationYear}");
        }
    }

    class Author : Book
    {
        private string authorName;
        private string bio;

        public Author(string title, int publicationYear, string authorName, string bio)
            : base(title, publicationYear)
        {
            this.authorName = authorName;
            this.bio = bio;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Author : {authorName}");
            Console.WriteLine($"Bio    : {bio}");
        }
    }

    // Device -> Thermostat

    class Device
    {
        protected int deviceId;
        protected string status;

        public Device(int deviceId, string status)
        {
            this.deviceId = deviceId;
            this.status = status;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Device ID : {deviceId}");
            Console.WriteLine($"Status    : {status}");
        }
    }

    class Thermostat : Device
    {
        private int temperatureSetting;

        public Thermostat(int deviceId, string status, int temperatureSetting)
            : base(deviceId, status)
        {
            this.temperatureSetting = temperatureSetting;
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Temperature : {temperatureSetting}°C");
        }
    }
}