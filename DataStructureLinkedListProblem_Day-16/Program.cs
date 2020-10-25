// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace DataStructureLinkedListProblem_Day_16
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Linked List problem");
            LinkedList linkedList = new LinkedList();

            // UC 10- Sorting the elements of the Linked List In the Ascending order
            linkedList.InsertElement(56);
            linkedList.InsertElement(30);
            linkedList.InsertElement(40);
            linkedList.InsertElement(70);
            linkedList.DisplayList();
            linkedList.SortLinkedList();
            linkedList.DisplayList();
            Console.ReadLine();

        }
    }
}
