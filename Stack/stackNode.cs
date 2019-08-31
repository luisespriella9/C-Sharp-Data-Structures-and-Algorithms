public class StackNode
{
    public int value;
    public StackNode next;
    /// <summary>
    /// Constructor, takes in value and next
    /// </summary>
    /// <param name="value"></param>
    /// <param name="next"></param>
    public StackNode(int value, StackNode next)
    {
        this.value = value;
        this.next = next;
    }
    /// <summary>
    /// Constructor, takes in value
    /// </summary>
    /// <param name="value"></param>
    public StackNode(int value)
    {
        this.value = value;
        this.next = null;
    }
    /// <summary>
    /// Empty Constructor
    /// </summary>
    public StackNode()
    {
        this.value = 0;
        this.next = null;
    }
}