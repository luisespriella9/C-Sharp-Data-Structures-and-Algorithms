public class ListNode
{
    public int value;
    public ListNode next;
    /// <summary>
    /// Constructor, takes in value and next
    /// </summary>
    /// <param name="value"></param>
    /// <param name="next"></param>
    public ListNode(int value, ListNode next)
    {
        this.value = value;
        this.next = next;
    }
    /// <summary>
    /// Constructor, takes in value
    /// </summary>
    /// <param name="value"></param>
    public ListNode(int value)
    {
        this.value = value;
        this.next = null;
    }
    /// <summary>
    /// Empty Constructor
    /// </summary>
    public ListNode()
    {
        this.value = 0;
        this.next = null;
    }
}
