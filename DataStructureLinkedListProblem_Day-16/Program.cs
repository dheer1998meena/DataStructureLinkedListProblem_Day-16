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
           // UC1 Crating simple Linked List insert the node .
            linkedList.InsertLast(56);
            linkedList.InsertLast(30);
            linkedList.InsertLast(70);
            // UC2 Inserting the node at the begining.
            linkedList.InsertFront(70);
            linkedList.InsertFront(30);
            linkedList.InsertFront(56);
            //UC3 Crating Linked List Append the node at last.
            linkedList.AppendAtLast(56);
            linkedList.AppendAtLast(30);
            linkedList.AppendAtLast(70);
            linkedList.DisplayList();
        }
    }
}
