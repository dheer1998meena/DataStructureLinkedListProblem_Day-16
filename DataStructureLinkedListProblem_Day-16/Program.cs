using System;

namespace DataStructureLinkedListProblem_Day_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Linked List problem");
            LinkedList linkedList = new LinkedList();
            linkedList.InsertLast(56);
            linkedList.InsertLast(30);
            linkedList.InsertLast(70);
            linkedList.DisplayList();
        }
    }
}
