using System;
using System.Collections.Generic;

namespace Day15
{
    abstract class JobRole
    {
        public string Name {get;set; }

        public JobRole(string name)
        {
            Name = name;
        }

        public abstract void Screen();
    }

    class SoftwareEngineer:JobRole
    {
        public SoftwareEngineer(string name)
            :base(name)
        {
        }

        public override void Screen()
        {
            Console.WriteLine(Name+" - Software Engineer Resume");
        }
    }

    class DataScientist:JobRole
    {
        public DataScientist(string name)
            :base(name)
        {
        }

        public override void Screen()
        {
            Console.WriteLine(Name+" - Data Scientist Resume");
        }
    }

    class Resume<T> where T:JobRole
    {
        private List<T> resumes =new List<T>();

        public void Add(T role)
        {
            resumes.Add(role);
        }

        public void ScreenAll()
        {
            foreach (T role in resumes)
            {
                role.Screen();
            }
        }
    }
}