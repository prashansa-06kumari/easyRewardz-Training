using System;
using System.Collections.Generic;

class SortStackUsingRecursion
{
    public static void Sort(Stack<int> stack)
    {
        if (stack.Count == 0)
        {
            return;
        }

        int value = stack.Pop();

        Sort(stack);

        InsertSorted(stack, value);
    }

    private static void InsertSorted(Stack<int> stack, int value)
    {
        if (stack.Count == 0 || stack.Peek() <= value)
        {
            stack.Push(value);
            return;
        }

        int top = stack.Pop();

        InsertSorted(stack, value);

        stack.Push(top);
    }

    public static void Display(Stack<int> stack)
    {
        foreach (int value in stack)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine();
    }
}