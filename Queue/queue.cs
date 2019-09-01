using System.Collections.Generic;

public class Queue<T>
{
    public ListNode<T> first;
    public ListNode<T> last;

    public Queue()
    {
        first = default;
        last = default;
    }
    public void Add(T item)
    {
        ListNode<T> node = new ListNode<T>(item);
        if ((first == null) && (last == null))
        {
            //this should always be the case if the queue is empty
            first = node;
            last = node;
        }
        last.next = node;
        last = node;
    }
    public T Remove()
    {
        if (first == null)
        {
            return default;
        }
        T retValue = first.value;
        first = first.next;
        return retValue;
    }
    public T Peek()
    {
        return first.value;
    }
    public bool IsEmpty()
    {
        if ((first == null) && (last == null))
        {
            //this should always be the case if the queue is empty
            return true;
        }
        return false;
    }
    public string PrintQueue()
    {
        ListNode<T> nodePointer = first;
        Stack<T> stack = new Stack<T>(); //To maintain values ordered
        while (nodePointer != null)
        {
            stack.Push(nodePointer.value);
            nodePointer = nodePointer.next;
        }
        return stack.PrintStack();
    }
}