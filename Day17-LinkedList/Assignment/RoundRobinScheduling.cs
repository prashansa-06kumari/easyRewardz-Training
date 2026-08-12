using System;

class Process
{
    public int ProcessId { get; set; }
    public int BurstTime { get; set; }
    public int RemainingTime { get; set; }
    public int WaitingTime { get; set; }
    public int TurnaroundTime { get; set; }

    public Process(int processId, int burstTime)
    {
        ProcessId = processId;
        BurstTime = burstTime;
        RemainingTime = burstTime;
    }
}

class ProcessNode
{
    public Process Data { get; set; }
    public ProcessNode Next { get; set; }

    public ProcessNode(Process process)
    {
        Data = process;
    }
}

class RoundRobin
{
    private ProcessNode head;
    private ProcessNode tail;

    public void AddProcess(Process process)
    {
        ProcessNode node = new ProcessNode(process);

        if (head == null)
        {
            head = tail = node;
            node.Next = head;
        }
        else
        {
            tail.Next = node;
            tail = node;
            tail.Next = head;
        }
    }

    public void Schedule(int quantum)
    {
        if (head == null)
            return;

        int time = 0;
        int completed = 0;
        int totalProcesses = Count();

        ProcessNode current = head;

        while (completed < totalProcesses)
        {
            if (current.Data.RemainingTime > 0)
            {
                int executionTime = Math.Min(quantum, current.Data.RemainingTime);

                current.Data.RemainingTime -= executionTime;
                time += executionTime;

                if (current.Data.RemainingTime == 0)
                {
                    completed++;
                    current.Data.TurnaroundTime = time;
                    current.Data.WaitingTime =
                        current.Data.TurnaroundTime - current.Data.BurstTime;
                }
            }

            current = current.Next;
        }

        DisplayResults();
    }

    private int Count()
    {
        int count = 0;

        if (head == null)
            return 0;

        ProcessNode current = head;

        do
        {
            count++;
            current = current.Next;
        } while (current != head);

        return count;
    }

    private void DisplayResults()
    {
        double totalWaiting = 0;
        double totalTurnaround = 0;

        ProcessNode current = head;

        do
        {
            Console.WriteLine(
                $"P{current.Data.ProcessId} | " +
                $"Waiting: {current.Data.WaitingTime} | " +
                $"Turnaround: {current.Data.TurnaroundTime}");

            totalWaiting += current.Data.WaitingTime;
            totalTurnaround += current.Data.TurnaroundTime;

            current = current.Next;

        } while (current != head);

        int count = Count();

        Console.WriteLine($"Average Waiting Time: {totalWaiting / count}");
        Console.WriteLine($"Average Turnaround Time: {totalTurnaround / count}");
    }
}