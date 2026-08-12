using System;

class TextStateNode
{
    public string Text { get; set; }
    public TextStateNode Next { get; set; }
    public TextStateNode Prev { get; set; }

    public TextStateNode(string text)
    {
        Text = text;
    }
}

class TextEditorHistory
{
    private TextStateNode head;
    private TextStateNode tail;
    private TextStateNode current;

    private const int MaxHistory = 10;
    private int count;

    public void AddState(string text)
    {
        TextStateNode newNode = new TextStateNode(text);

        if (head == null)
        {
            head = tail = current = newNode;
            count = 1;
            return;
        }

        current.Next = null;
        tail = current;

        newNode.Prev = current;
        current.Next = newNode;
        current = newNode;
        tail = newNode;

        count++;

        if (count > MaxHistory)
        {
            head = head.Next;
            head.Prev = null;
            count--;
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
            current = current.Prev;
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
            current = current.Next;
    }

    public void DisplayCurrentState()
    {
        if (current != null)
            Console.WriteLine($"Current Text: {current.Text}");
        else
            Console.WriteLine("No text.");
    }
}