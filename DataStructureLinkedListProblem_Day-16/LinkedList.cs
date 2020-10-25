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
        //UC8 Ability to Insert node 40 after node 30
        public int InsertParticularPosition(int position, int newData)
        {
            //Creating a new node.
            Node newNode = new Node(newData);
            if(this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                //Creating a temporary variable which act as head pointer to check for new node.
                Node temp = this.head;
                bool flag = true;
                while(flag)
                {
                    // Checking if the pointer is pointing towards entered position
                    if(temp.data == position)
                    {
                        flag = false;
                    }
                    else
                    {
                        temp = temp.Next;
                    }
                }
                //Declaring new node to points toward next node
                newNode.Next = temp.Next;
                temp.Next = newNode;
            }
            return newData;
        }
        // UC9 Method to display the size of the linked list
        public int SizeOfList()
        {
            int size = 0;
            // if head is poitning to null then size of list is zero.
            if(this.head == null)
            {
                return 0;
            }
            else
            {
                // Creating a temporay variable to check if head is pointing to null or not.
                Node temp = this.head;
                //If head is not pointing to null then increasing the size of list.
                while(temp.Next != null)
                {
                    size++;
                    temp = temp.Next;
                }
                return size + 1;
            }
        }
        //UC9 Method to search for a particular element in the linked list
        public int SearchForAnElement(int data)
        {
            int position = 0;
            // If head is poitning to null the size of list is zero.
            if(this.head == null)
            {
                Console.WriteLine("Linked List is Empty");
                return -1;
            }
            else
            {
                // Creating a temporary variable to check head is pointing to null or not.
                Node temp = this.head;
                bool flag = true;
                while(flag)
                {
                    position++;
                    if(temp.data == data)
                    {
                        flag = false;
                    }
                    else if (temp.Next != null)
                    {
                        if(temp.data == data)
                        {
                            return position;
                        }
                        else
                        {
                            flag = false;
                            position++;
                        }
                    }
                    else
                    {
                        temp = temp.Next;
                    }
                }
                // If the position is exceeding the size of list then showing error message
                if(position == SizeOfList()+1)
                {
                    Console.WriteLine("Element is not found in the list");
                    return 0;
                }
                return position;
            }
        }
        // UC9 Deleting a particular element in the Linked List
        public void DeleteElement(int newData)
        {
            // Checking If head is pointing to null or not
           if (this.head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
           else
            {
                //Creating a temporary variable to check head is pointing to null or not.
                Node temp = this.head;
                //Checking if the second node pointer is pointing to null or not.
                while(temp.Next.Next!= null)
                {
                    // If the second node pointer has data then moving pointer to next node.
                    if(temp.Next.data==newData)
                    {
                        temp.Next = temp.Next.Next;
                    }
                    else
                    {
                        temp = temp.Next;
                    }
                }
                // If second node pointer is pointing to null then value is allocating to garbage collector and deleting that data.
                if(temp.Next.Next== null)
                {
                    if(temp.Next.data == newData)
                    {
                        temp.Next = null;
                    }
                }
            }
        }
        // UC 10- Sorting the elements of the Linked List In the Ascending order
        public void SortLinkedList()
        {
            // Checking If head is pointing to null or not
            if (this.head == null)
            {
                Console.WriteLine("The LinkedList is Empty");
            }
            else
            {
                //temporary variable to check if head is pointing to null or not and traverse along the linked list
                Node temp = this.head;
                // iterating along the linked list
                while (temp.Next != null)
                {
                    int temp2 = 0;
                    // checking if the previous data is greater than the next data in the pointer
                    if (temp.data > temp.Next.data)
                    {
                        temp2 = temp.data;
                        temp.data = temp.Next.data;
                        temp.Next.data = temp2;
                    }
                    temp = temp.Next;
                }
            }
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
