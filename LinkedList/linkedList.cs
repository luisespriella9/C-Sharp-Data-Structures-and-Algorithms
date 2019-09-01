public class LinkedList<T>
{
    public ListNode<T> head;
    public ListNode<T> tail;
    /// <summary>
    /// Constructor, takes in Linked List head
    /// </summary>
    /// <param name="head"></param>
    public LinkedList(ListNode<T> node)
    {
        head = node;
        tail = head;
    }
    /// <summary>
    /// Empty Constructor
    /// </summary>
    public LinkedList()
    {
        head = null;
        tail = null;
    }
    /// <summary>
    /// Adds node to beginning of the linked list
    /// </summary>
    /// <param name="value"></param>
    public void AddFirst(T value)
    {
        ListNode<T> newHead = new ListNode<T>(value, head);
        if (head == null)
        {
            tail = newHead;
        }
        head = newHead;
    }
    /// <summary>
    /// Adds node to the end of linked list
    /// </summary>
    /// <param name="value"></param>
    public void InsertAtTail(T value)
    {
        ListNode<T> node = new ListNode<T>(value);
        if (tail!=null)
        {
            tail.next = node;
        }
        tail = node;
        if (head == null)
        {
            //if list is empty make node head and tail
            head = node;
        }


    }
    /// <summary>
    /// Removes node at specific index in linked list
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public void Remove(T value)
    {
        ListNode<T> pointer = head;
        if (pointer.value.Equals(value))
        {
            //if head contains value
            head = head.next;
        }
        while (pointer != null)
        {
            if (pointer.next != null)
            {
                if (pointer.next.value.Equals(value))
                {
                    pointer.next = pointer.next.next;
                }
            }
            pointer = pointer.next;
        }
    }
    /// <summary>
    /// Returns all values of linked list
    /// </summary>
    /// <returns></returns>
    public string Values()
    {
        string result = "";
        ListNode<T> pointer = head;
        while (pointer != null)
        {
            result = result + pointer.value.ToString() + " -> ";
            pointer = pointer.next;
        }
        result += " null ";
        return result;
    }
    /// <summary>
    /// Returns size of linked list
    /// </summary>
    /// <returns></returns>
    public int Size()
    {
        int count = 0;
        ListNode<T> pointer = head;
        while (pointer != null)
        {
            count += 1;
            pointer = pointer.next;
        }
        return count;
    }
}
