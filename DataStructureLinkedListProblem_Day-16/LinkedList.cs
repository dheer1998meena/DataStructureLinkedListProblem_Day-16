using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureLinkedListProblem_Day_16
{
    public class LinkedList
    {
        public Node head;
        /// <summary>
        ///  UC1 Crating LinkList insert the node at last.
        /// </summary>
        /// <param name="newData"></param>
        public void InsertLast(int newData)
        {
            // Creating a new node to insert.
            Node newNode = new Node(newData);
            // Initially head point to null.
            //Checking if condition first.
            if (head == null)
            {
                head = newNode; // if head is null then head to asign new node here(head will point new node).
            }
            // else get the last node.
            // then last node will attach new node 
            else
            {
                Node temp = GetLastNode();
                temp.Next = newNode;
            }
            Console.WriteLine("Inserted into list :" + newNode.data);
        }
        /// <summary>
        /// Creating GetLastNode for identify the last node
        /// </summary>
        /// <returns></returns>
        public Node GetLastNode()
        {
            //Here we will take the copy the head into temp.
            Node temp = head;
            //iterating the temp till the temp is pointing towards null.
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }
        /// <summary>
        /// Creating DisplayList metbhod for displaying the Linkedlist
        /// </summary>
        public void DisplayList()
        {
            Console.WriteLine("Displaying the Linked list :");
            //Here we will take the copy the head into temp.
            Node temp = head;
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
