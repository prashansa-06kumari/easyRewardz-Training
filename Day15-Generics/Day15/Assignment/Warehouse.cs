using System;
using System.Collections.Generic;

namespace Day15
{
    abstract class WarehouseItem
    {
        public int Id { get;set; }
        public string Name { get; set; }

        public WarehouseItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void Show();
    }

    class Electronics :WarehouseItem
    {
        public Electronics(int id, string name)
            : base(id, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine(Id + " " + Name + " - Electronics");
        }
    }

    class Grocery : WarehouseItem
    {
        public Grocery(int id, string name)
            : base(id, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine(Id + " " + Name + " - Grocery");
        }
    }

    class Furniture : WarehouseItem
    {
        public Furniture(int id, string name)
            : base(id, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine(Id + " " + Name + " - Furniture");
        }
    }

    class Storage<T> where T : WarehouseItem
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void ShowAll()
        {
            foreach (T item in items)
            {
                item.Show();
            }
        }
    }
}