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
            //Test Linked List
            Console.WriteLine("Testing Linked List");
            LinkedList<int> list = new LinkedList<int>();
            list.InsertAtTail(5);
            list.InsertAtTail(8);
            list.InsertAtTail(12);
            Console.WriteLine("list: " + list.Values().ToString()); //print list values
            Console.WriteLine("list size: " + list.Size().ToString()); //print list size
            Console.WriteLine("remove 5"); //print list size
            list.Remove(5);
            Console.WriteLine("list: " + list.Values().ToString()); //print list values
            Console.WriteLine("remove 8"); //print list size
            list.Remove(8);
            Console.WriteLine("list: " + list.Values().ToString()); //print list values

            //Test Stack
            Console.WriteLine("Testing Stack");
            Stack<string> stack = new Stack<string>();
            Console.WriteLine("push hello");
            stack.Push("hello");
            Console.WriteLine("push world");
            stack.Push("world");
            Console.WriteLine("top is " + stack.Peek().ToString());
            Console.WriteLine("stack: " + stack.PrintStack().ToString());
            Console.WriteLine("pop");
            stack.Pop();
            Console.WriteLine("stack: " + stack.PrintStack().ToString());
            Console.WriteLine("pop");
            stack.Pop();
            Console.WriteLine("stack: " + stack.PrintStack().ToString());
        }
    }
}
