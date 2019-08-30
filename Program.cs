using System;

namespace Data_Structures_and_Algorithms
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Testing Linked List");
            LinkedList list = new LinkedList();
            list.InsertAtTail(5);
            list.InsertAtTail(8);
            list.InsertAtTail(12);
            Console.WriteLine(list.Values()); //print list values
            Console.WriteLine("list size: " + list.Size().ToString()); //print list size
            Console.WriteLine("remove 5"); //print list size
            list.Remove(5);
            Console.WriteLine(list.Values()); //print list values
            Console.WriteLine("remove 8"); //print list size
            list.Remove(8);
            Console.WriteLine(list.Values()); //print list values

        }
    }
}
