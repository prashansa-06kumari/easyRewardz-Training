using System;

class TaskItem
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public int Priority { get; set; }
    public string DueDate { get; set; }

    public TaskItem(int taskId, string taskName, int priority, string dueDate)
    {
        TaskId = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
    }
}

class TaskNode
{
    public TaskItem Data { get; set; }
    public TaskNode Next { get; set; }

    public TaskNode(TaskItem task)
    {
        Data = task;
    }
}

class TaskScheduler
{
    private TaskNode head;
    private TaskNode tail;
    private TaskNode current;

    public void AddAtBeginning(TaskItem task)
    {
        TaskNode newNode = new TaskNode(task);

        if (head == null)
        {
            head = tail = newNode;
            newNode.Next = head;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
            tail.Next = head;
        }

        if (current == null)
            current = head;
    }

    public void AddAtEnd(TaskItem task)
    {
        TaskNode newNode = new TaskNode(task);

        if (head == null)
        {
            head = tail = newNode;
            newNode.Next = head;
            current = head;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
            tail.Next = head;
        }
    }

    public void Remove(int taskId)
    {
        if (head == null)
            return;

        TaskNode previous = tail;
        TaskNode node = head;

        do
        {
            if (node.Data.TaskId == taskId)
            {
                if (node == head)
                    head = head.Next;

                if (node == tail)
                    tail = previous;

                previous.Next = node.Next;

                if (current == node)
                    current = node.Next;

                if (node == head && head == tail)
                    head = tail = null;

                return;
            }

            previous = node;
            node = node.Next;

        } while (node != head);
    }

    public void ViewCurrentTask()
    {
        if (current == null)
        {
            Console.WriteLine("No tasks.");
            return;
        }

        Console.WriteLine(
            $"Current Task: {current.Data.TaskId} - {current.Data.TaskName}");
    }

    public void MoveNext()
    {
        if (current != null)
            current = current.Next;
    }

    public void Display()
    {
        if (head == null)
            return;

        TaskNode currentNode = head;

        do
        {
            Console.WriteLine(
                $"{currentNode.Data.TaskId} | " +
                $"{currentNode.Data.TaskName} | " +
                $"Priority: {currentNode.Data.Priority} | " +
                $"Due: {currentNode.Data.DueDate}");

            currentNode = currentNode.Next;

        } while (currentNode != head);
    }

    public void SearchByPriority(int priority)
    {
        if (head == null)
            return;

        TaskNode currentNode = head;

        do
        {
            if (currentNode.Data.Priority == priority)
                Console.WriteLine(currentNode.Data.TaskName);

            currentNode = currentNode.Next;

        } while (currentNode != head);
    }
}