namespace App.Topics.LinkedList.T2b_DoubleLinkedList;

public class DoubleLinkedList<T>
{
    public T Value { get; }
    public DoubleLinkedList<T>? Prev { get; private set; }
    public DoubleLinkedList<T>? Next { get; private set; }

    public int Count
    {
        get
        {
            var N = this;
            while (N.Prev != null)
            {
                N = N.Prev;
            }

            int count = 0;
            while (N != null)
            {
                count++;
                N = N.Next;
            }
            return count;
        }
    }

    public DoubleLinkedList(T value)
    {
        Value = value;
    }

    public void AddBefore(T value)
    {
        var tmpList = new DoubleLinkedList<T>(value);

        tmpList.Prev = Prev;
        tmpList.Next = this;

        if (Prev != null)
        {
            Prev.Next = tmpList;
        }
        Prev = tmpList;
    }

    public void AddAfter(T value)
    {
        var tmpList = new DoubleLinkedList<T>(value);

        tmpList.Prev = this;
        tmpList.Next = Next;

        if (Next != null)
        {
            Next.Prev = tmpList;
        }
        Next = tmpList;
    }

    public void AddFirst(T value)
    {
        var head = this;
        while (head.Prev != null)
        {
            head = head.Prev;
        }

        head.AddBefore(value);
    }

    public void AddLast(T value)
    {
        var tail = this;
        while (tail.Next != null)
        {
            tail = tail.Next;
        }

        tail.AddAfter(value);
    }

    public T[] ToArray()
    {
        var current = this;
        while (current.Prev != null)
        {
            current = current.Prev;
        }

        var arr = new T[Count];
        int index = 0;

        while (current != null)
        {
            arr[index++] = current.Value;
            current = current.Next;
        }

        return arr;
    }
}