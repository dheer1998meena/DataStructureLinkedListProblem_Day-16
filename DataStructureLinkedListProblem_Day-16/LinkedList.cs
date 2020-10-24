// --------------------------------------------------------------------------------------------------------------------
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
        public void InsertElement(int newData)
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
            //initialising temp variable for checking head pointer
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
        ///  UC3 Crating Linked List Append the node at last .
        /// </summary>
        /// <param name="newData"></param>
        public void AppendAtLast(int newData)
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
                Node lastNode = GetAppendLastNode();
                lastNode.Next = newNode;
            }
            Console.WriteLine("Inserted into list at Append Last:" + newNode.data);
        }
        /// <summary>
        /// Creating GetLastNode for identify the last node
        /// </summary>
        /// <returns></returns>
        public Node GetAppendLastNode()
        {
            //initialising temp variable for checking head pointer
            Node temp = this.head;
            //iterating the temp till the temp is pointing towards null.
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }
        /// <summary>
        /// UC4 Inset the node at a particular position of linked list.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="newData"></param>
        /// <returns></returns>
        public Node InsertAtParticularPosition(int position , int newData)
        {
            //If the position is not found the beginging then return an Invalid position
            if (position <1)
            {
                Console.WriteLine("Invalid Position");
            }
           //If position is first Insert at the begining of the linked list
            else if (position ==1)
            {
                Node newNode = new Node(newData);
                newNode.Next = this.head;
                head = newNode;
            }
            else
            {
                //Iterating while loop decrementation of position.
                while (position-- !=0)
                {
                    if (position == 1)
                    {
                        //Creating a new node
                        Node node = new Node(newData);
                        //Adding the node to the next position of the node
                        node.Next = this.head.Next;
                        head.Next = node;
                        break;
                    }
                    head = head.Next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position is out of range");
                }
            }
            return head;
        }
        /// <summary>
        ///UC5 Deleting the first node from the Linked List.
        /// </summary>
        /// <returns></returns>
        public Node DeleteFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            else
            {
                Console.WriteLine("Deleted element is :" + this.head.data);
                //Here move the head pointer to next node, previous will automatically deleted.
                this.head = this.head.Next;
                return this.head;
            }
        }
        /// <summary>
        /// UC6 Deleting last node from the linked list.
        /// </summary>
        /// <returns></returns>
        public Node DeleteLastNode()
        {
            if(this.head == null)
            {
                return null;
            }
            else if (this.head.Next == null)
            {
                return null;
            }
            else
            {
                Node temp = this.head;
                // iterating while loop till the last node is not equal to null.
                while (temp.Next.Next != null)
                {
                    temp = temp.Next;
                }
                //Here delete the last node and it is allocated to garbage collection
                temp.Next = null;
                return null;
            }
        }
        /// <summary>
        /// UC7 Seraching element in the linked list.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SearchNode(int value)
        {
            //initialising temp variable for checking head pointer
            Node temp = new Node(value);
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Node is found :" + value);
                    return true;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Node is not found");
            return false;
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
                    //checking if other nodes are present in the list by moving the temp to next node
                    temp = temp.Next;
                }
            }
        }

    }
}
