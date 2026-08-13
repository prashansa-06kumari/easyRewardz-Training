using System;
using System.Collections.Generic;

class CustomHashMap
{
    private class Entry
    {
        public int Key;
        public string Value;
        public Entry Next;

        public Entry(int key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    private Entry[] buckets;

    public CustomHashMap(int size)
    {
        buckets = new Entry[size];
    }

    private int GetIndex(int key)
    {
        return Math.Abs(key) % buckets.Length;
    }

    public void Put(int key, string value)
    {
        int index = GetIndex(key);

        Entry current = buckets[index];

        while (current != null)
        {
            if (current.Key == key)
            {
                current.Value = value;
                return;
            }

            current = current.Next;
        }

        Entry newEntry = new Entry(key, value);

        newEntry.Next = buckets[index];

        buckets[index] = newEntry;
    }

    public string Get(int key)
    {
        int index = GetIndex(key);

        Entry current = buckets[index];

        while (current != null)
        {
            if (current.Key == key)
            {
                return current.Value;
            }

            current = current.Next;
        }

        return null;
    }

    public void Remove(int key)
    {
        int index = GetIndex(key);

        Entry current = buckets[index];
        Entry previous = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (previous == null)
                {
                    buckets[index] = current.Next;
                }
                else
                {
                    previous.Next = current.Next;
                }

                return;
            }

            previous = current;
            current = current.Next;
        }
    }
}