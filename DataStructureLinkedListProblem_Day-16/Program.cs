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

            // UC9 Ability to delete a particular node
            linkedList.InsertElement(56);
            linkedList.InsertElement(30);
            linkedList.InsertElement(40);
            linkedList.InsertElement(70);
            Console.WriteLine("Enter the element to be deleted ");
            int delete = Convert.ToInt32(Console.ReadLine());
            int ifPresent = linkedList.SearchForAnElement(delete);
            if (ifPresent >= 1)
            {
                linkedList.DeleteElement(delete);
                linkedList.DisplayList();
            }
            // Showing the size of the list
            Console.WriteLine("\nSize of the list after deleting " + linkedList.SizeOfList());
            Console.ReadLine();

        }
    }
}
