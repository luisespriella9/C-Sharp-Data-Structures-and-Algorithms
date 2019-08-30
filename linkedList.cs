using System;
using System.Collections.Generic;

public class LinkedList
{
    public ListNode head;
    public ListNode tail;
    /// <summary>
    /// Constructor, takes in Linked List head
    /// </summary>
    /// <param name="head"></param>
    public LinkedList(ListNode node)
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
    public void AddFirst(int value)
    {
        ListNode newHead = new ListNode(value, head);
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
    public void InsertAtTail(int value)
    {
        ListNode node = new ListNode(value);
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
    public void Remove(int value)
    {
        ListNode pointer = head;
        if (pointer.value == 0)
        {
            return;
        }
        while (pointer != null)
        {
            //Check if head needs to be removed and traverse linked list until head is not equal to removed value
            if (pointer.value == value)
            {
                head = pointer.next;
                pointer = pointer.next;
            }
            else
            {
                break;
            }
        }
        while (pointer != null)
        {
            if (pointer.next != null)
            {
                if (pointer.next.value == value)
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
        ListNode pointer = head;
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
        ListNode pointer = head;
        while (pointer != null)
        {
            count += 1;
            pointer = pointer.next;
        }
        return count;
    }
}
