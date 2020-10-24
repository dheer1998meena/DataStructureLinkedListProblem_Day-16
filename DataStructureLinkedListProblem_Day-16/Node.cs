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
    public class Node
    {
        public int data;
        public Node Next;
        //Creating Paratermeterized Constructor.
        public Node(int data)
        {
            this.data = data;
            this.Next = null;
        }
    }
}
