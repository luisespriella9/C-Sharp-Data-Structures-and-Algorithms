public class Stack<T>
{
    public StackNode<T> top;
    /// <summary>
    /// Constructor, takes in Linked List head
    /// </summary>
    /// <param name="head"></param>
    public Stack(StackNode<T> node)
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
    public void Push()
    {

    }
    public int Pop()
    {
        return 0;
    }
}