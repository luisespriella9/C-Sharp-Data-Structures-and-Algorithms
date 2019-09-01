public class Stack<T>
{
    public ListNode<T> top;
    /// <summary>
    /// Constructor, takes in Linked List head
    /// </summary>
    /// <param name="head"></param>
    public Stack(ListNode<T> node)
    {
        top = node;
    }
    /// <summary>
    /// Empty Constructor
    /// </summary>
    public Stack()
    {
        top = null;
    }
    /// <summary>
    /// pushes new value into top of the stack
    /// </summary>
    /// <param name="value"></param>
    public void Push(T value)
    {
        ListNode<T> node = new ListNode<T>(value);
        if (top != default)
        {
            node.next = top;
        }
        top = node;
    }
    /// <summary>
    /// removes top value from stack. If empty returns default data type value (ex: null, 0, etc)
    /// </summary>
    /// <returns></returns>
    public T Pop()
    {
        if (top == default)
        {
            return default;
        }
        T topValue = top.value;
        top = top.next;
        return topValue;
    }
    /// <summary>
    /// returns top value of the stack. If empty returns default data type value (ex: ynull, 0, etc)
    /// </summary>
    /// <returns></returns>
    public T Peek()
    {
        return top.value;
    }
    /// <summary>
    /// returns if stack is empty
    /// </summary>
    /// <returns></returns>
    public bool IsEmpty()
    {
        if (top == default)
        {
            return true;
        }
        return false;
    }
    public string PrintStack()
    {
        ListNode<T>  pointer = top;
        string result = "";
        while (pointer != default)
        {
            result += pointer.value.ToString() + " -> ";
            pointer = pointer.next;
        }
        result += "null";
        return result;
    }
}