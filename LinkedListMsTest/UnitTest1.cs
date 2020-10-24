// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructureLinkedListProblem_Day_16;

namespace LinkedListMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(30)]
        [TestMethod]
        public void GivenElementSearchElementTest(int value)
        {
            //Arrange
            bool expected = true;
            LinkedList linkedlist = new LinkedList();
            //Act
            bool actual = linkedlist.SearchNode(value);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
