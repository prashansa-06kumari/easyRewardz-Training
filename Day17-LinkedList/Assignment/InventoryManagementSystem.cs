using System;

class InventoryItem
{
    public int ItemId { get; set; }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public InventoryItem(int itemId, string itemName, int quantity, double price)
    {
        ItemId = itemId;
        ItemName = itemName;
        Quantity = quantity;
        Price = price;
    }
}

class InventoryNode
{
    public InventoryItem Data { get; set; }
    public InventoryNode Next { get; set; }

    public InventoryNode(InventoryItem item)
    {
        Data = item;
    }
}

class InventoryLinkedList
{
    private InventoryNode head;
    private InventoryNode tail;

    public void AddAtBeginning(InventoryItem item)
    {
        InventoryNode node = new InventoryNode(item);

        if (head == null)
            head = tail = node;
        else
        {
            node.Next = head;
            head = node;
        }
    }

    public void AddAtEnd(InventoryItem item)
    {
        InventoryNode node = new InventoryNode(item);

        if (head == null)
            head = tail = node;
        else
        {
            tail.Next = node;
            tail = node;
        }
    }

    public void AddAtPosition(InventoryItem item, int position)
    {
        if (position <= 1)
        {
            AddAtBeginning(item);
            return;
        }

        InventoryNode current = head;

        for (int i = 1; i < position - 1 && current != null; i++)
            current = current.Next;

        if (current == null)
            return;

        InventoryNode node = new InventoryNode(item);
        node.Next = current.Next;
        current.Next = node;

        if (node.Next == null)
            tail = node;
    }

    public void Remove(int itemId)
    {
        if (head == null)
            return;

        if (head.Data.ItemId == itemId)
        {
            head = head.Next;

            if (head == null)
                tail = null;

            return;
        }

        InventoryNode current = head;

        while (current.Next != null)
        {
            if (current.Next.Data.ItemId == itemId)
            {
                if (current.Next == tail)
                    tail = current;

                current.Next = current.Next.Next;
                return;
            }

            current = current.Next;
        }
    }

    public void UpdateQuantity(int itemId, int quantity)
    {
        InventoryNode current = head;

        while (current != null)
        {
            if (current.Data.ItemId == itemId)
            {
                current.Data.Quantity = quantity;
                return;
            }

            current = current.Next;
        }
    }

    public InventoryItem SearchById(int itemId)
    {
        InventoryNode current = head;

        while (current != null)
        {
            if (current.Data.ItemId == itemId)
                return current.Data;

            current = current.Next;
        }

        return null;
    }

    public void SearchByName(string name)
    {
        InventoryNode current = head;

        while (current != null)
        {
            if (current.Data.ItemName.Equals(name, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine(current.Data.ItemName);

            current = current.Next;
        }
    }

    public double TotalValue()
    {
        double total = 0;
        InventoryNode current = head;

        while (current != null)
        {
            total += current.Data.Price * current.Data.Quantity;
            current = current.Next;
        }

        return total;
    }

    public void Display()
    {
        InventoryNode current = head;

        while (current != null)
        {
            Console.WriteLine(
                $"{current.Data.ItemId} | {current.Data.ItemName} | " +
                $"Qty: {current.Data.Quantity} | Price: {current.Data.Price}");

            current = current.Next;
        }
    }
}