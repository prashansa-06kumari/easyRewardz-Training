using System;
using System.Collections.Generic;

namespace Day15
{
    abstract class CourseType
    {
        public string Name {get;set; }

        public CourseType(string name)
        {
            Name=name;
        }

        public abstract void Evaluate();
    }

    class ExamCourse : CourseType
    {
        public ExamCourse(string name)
            : base(name)
        {
        }

        public override void Evaluate()
        {
            Console.WriteLine(Name +" - Exam Evaluation");
        }
    }

    class AssignmentCourse:CourseType
    {
        public AssignmentCourse(string name)
            :base(name)
        {
        }

        public override void Evaluate()
        {
            Console.WriteLine(Name + " - Assignment Evaluation");
        }
    }

    class Course<T> where T :CourseType
    {
        private List<T> courses =new List<T>();

        public void Add(T course)
        {
            courses.Add(course);
        }

        public void Show()
        {
            foreach (T course in courses)
            {
                course.Evaluate();
            }
        }
    }
}