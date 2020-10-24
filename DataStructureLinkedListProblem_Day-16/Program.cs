// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace DataStructureLinkedListProblem_Day_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Linked List problem");
            LinkedList linkedList = new LinkedList();
           
            // Inserting the node in the lisnked list.
            linkedList.InsertElement(56);
            linkedList.InsertElement(30);
            linkedList.InsertElement(70);
            // UC7 Seraching element in the linked list.
            Console.WriteLine("Searching element 30 :"+ linkedList.SearchNode(30));
            linkedList.DisplayList();
        }
    }
}
