using System;

namespace Assignment
{
    class Student
    {
        public int rollNumber;
        protected string name;
        private double cgpa;
        // Parameterized constructor
        public Student(int rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.cgpa = cgpa;
        }
        public void SetCGPA(double cgpa)
        {
            this.cgpa = cgpa;
        }
        public double GetCGPA()
        {
            return cgpa;
        }
    }
}