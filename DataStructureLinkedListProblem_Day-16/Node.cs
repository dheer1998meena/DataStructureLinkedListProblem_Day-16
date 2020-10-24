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
