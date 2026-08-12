using System;

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public char Grade { get; set; }

    public Student(int rollNumber, string name, int age, char grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
    }
}

class StudentNode
{
    public Student Data { get; set; }
    public StudentNode Next { get; set; }

    public StudentNode(Student data)
    {
        Data = data;
        Next = null;
    }
}

class StudentLinkedList
{
    private StudentNode head;
    private StudentNode tail;

    public void AddAtBeginning(Student student)
    {
        StudentNode newNode = new StudentNode(student);

        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
        }
    }

    public void AddAtEnd(Student student)
    {
        StudentNode newNode = new StudentNode(student);

        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
    }

    public void AddAtPosition(Student student, int position)
    {
        if (position <= 1)
        {
            AddAtBeginning(student);
            return;
        }

        StudentNode newNode = new StudentNode(student);
        StudentNode current = head;

        for (int i = 1; i < position - 1 && current != null; i++)
        {
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        newNode.Next = current.Next;
        current.Next = newNode;

        if (newNode.Next == null)
            tail = newNode;
    }

    public void DeleteByRollNumber(int rollNumber)
    {
        if (head == null)
            return;

        if (head.Data.RollNumber == rollNumber)
        {
            head = head.Next;

            if (head == null)
                tail = null;

            return;
        }

        StudentNode current = head;

        while (current.Next != null)
        {
            if (current.Next.Data.RollNumber == rollNumber)
            {
                if (current.Next == tail)
                    tail = current;

                current.Next = current.Next.Next;
                return;
            }

            current = current.Next;
        }

        Console.WriteLine("Student not found.");
    }

    public Student Search(int rollNumber)
    {
        StudentNode current = head;

        while (current != null)
        {
            if (current.Data.RollNumber == rollNumber)
                return current.Data;

            current = current.Next;
        }

        return null;
    }

    public void UpdateGrade(int rollNumber, char grade)
    {
        Student student = Search(rollNumber);

        if (student != null)
            student.Grade = grade;
        else
            Console.WriteLine("Student not found.");
    }

    public void Display()
    {
        StudentNode current = head;

        while (current != null)
        {
            Console.WriteLine(
                $"Roll: {current.Data.RollNumber}, " +
                $"Name: {current.Data.Name}, " +
                $"Age: {current.Data.Age}, " +
                $"Grade: {current.Data.Grade}");

            current = current.Next;
        }
    }
}