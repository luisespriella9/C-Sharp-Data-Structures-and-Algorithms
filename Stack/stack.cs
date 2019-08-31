public class Stack
{
    public StackNode top;
    /// <summary>
    /// Constructor, takes in Linked List head
    /// </summary>
    /// <param name="head"></param>
    public Stack(StackNode node)
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
}
