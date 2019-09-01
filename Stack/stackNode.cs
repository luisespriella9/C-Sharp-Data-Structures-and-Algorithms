public class StackNode<T>
{
    public T value;
    public StackNode<T> next;
    /// <summary>
    /// Constructor, takes in value and next
    /// </summary>
    /// <param name="value"></param>
    /// <param name="next"></param>
    public StackNode(T value, StackNode<T> next)
    {
        this.value = value;
        this.next = next;
    }
    /// <summary>
    /// Constructor, takes in value
    /// </summary>
    /// <param name="value"></param>
    public StackNode(T value)
    {
        this.value = value;
        this.next = null;
    }
    /// <summary>
    /// Empty Constructor
    /// </summary>
    public StackNode()
    {
        this.value = default;
        this.next = null;
    }
}