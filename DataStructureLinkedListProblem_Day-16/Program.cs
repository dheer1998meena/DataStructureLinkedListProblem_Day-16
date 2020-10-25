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
           
            // Inserting the node in the lisnked list.
            linkedList.InsertElement(56);
            linkedList.InsertElement(30);
            linkedList.InsertElement(70);
            //UC8 Ability to Insert node 40 after node 30.
            linkedList.InsertParticularPosition(30, 40);
            linkedList.DisplayList();
        }
    }
}
