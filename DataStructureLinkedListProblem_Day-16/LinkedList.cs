﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureLinkedListProblem_Day_16
{
    public class LinkedList
    { 
        // Head node to mark the begining of the linked list
        public Node head;
        /// <summary>
        ///  UC1 Crating simple Linked List insert the node .
        /// </summary>
        /// <param name="newData"></param>
        public void InsertLast(int newData)
        {
            // Creating a new node to insert.
            Node newNode = new Node(newData);
            // Initially head point to null.
            //Checking if condition first.
            if (this.head == null)
            {
                this.head = newNode; // if head is null then head to asign new node here(head will point new node).
            }
            // else get the last node.
            // then last node will attach new node 
            else
            {
                Node lastNode = GetLastNode();
                lastNode.Next = newNode;
            }
            Console.WriteLine("Inserted into list :" + newNode.data);
        }
        /// <summary>
        /// Creating GetLastNode for identify the last node
        /// </summary>
        /// <returns></returns>
        public Node GetLastNode()
        {
            //Here we will take the copy the head  into temp.
            Node temp = this.head;
            //iterating the temp till the temp is pointing towards null.
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }
        /// <summary>
        /// UC2 Inserting the node at the begining.
        /// </summary>
        /// <param name="newData"></param>
        public void InsertFront(int newData)
        {

            // Creating a new node to insert. 
            Node newNode = new Node(newData);
            // Initiallizing next new node to head position.
            newNode.Next = this.head;
            // Here making the head point towards new node.
            this.head = newNode;
            Console.WriteLine("Inserted into list at beagining :" + newNode.data);
        }
        /// <summary>
        /// Creating DisplayList metbhod for displaying the Linkedlist
        /// </summary>
        public void DisplayList()
        {
            Console.WriteLine("Displaying the Linked list :");
            //Here we will take the copy the head into temp.
            Node temp = this.head;
            // If temp is null then then print the Linked list is empty.
            if (temp ==null)
            {
                Console.WriteLine("\n Linked List is empty");
                return;
            }
            // else we will iterating the temp til the temp is null using while loop. 
            else
            {
                while(temp != null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.Next;
                }
            }
        }

    }
}
