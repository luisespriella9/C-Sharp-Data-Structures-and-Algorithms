public class ListNode<T>
{
    public T value;
    public ListNode<T> next;
    /// <summary>
    /// Constructor, takes in value and next
    /// </summary>
    /// <param name="value"></param>
    /// <param name="next"></param>
    public ListNode(T value, ListNode<T> next)
    {
        this.value = value;
        this.next = next;
    }
    /// <summary>
    /// Constructor, takes in value
    /// </summary>
    /// <param name="value"></param>
    public ListNode(T value)
    {
        this.value = value;
        this.next = null;
    }
    /// <summary>
    /// Empty Constructor
    /// </summary>
    public ListNode()
    {
        this.value = default;
        this.next = null;
    }
}
