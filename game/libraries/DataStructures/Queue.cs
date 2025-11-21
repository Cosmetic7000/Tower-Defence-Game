using System.Drawing;

namespace Custom.DataStructures;

class Queue
{
    private readonly int Size;
    private readonly object[] Elements;
    private int BackPointer;

    Queue(int size)
    {
        Size = size;
        Elements = new object[size];
        BackPointer = -1;
    }

    public void Enqueue(object item)
    {
        // Check for overflow
        if (BackPointer == Size) { throw new System.Exception("Queue Overflow");}

        // Update pointer and add item
        BackPointer += 1;
        Elements[BackPointer] = item;
    }

    public object Dequeue()
    {
        // Check for underflow
        if (BackPointer == -1) { throw new System.Exception("Queue Underflow");}

        // Update pointer and return item
        object item = Elements[BackPointer];
        BackPointer -= 1;
        return item;
    }

    public object Peek()
    {
        return Elements[BackPointer];
    }

    public int Count()
    {
        return Elements.Count();
    }
    
    public bool IsEmpty()
    {
        return BackPointer == -1;
    }

    public void Clear()
    {
        BackPointer = -1;
    }
}