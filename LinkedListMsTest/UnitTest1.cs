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
        [DataRow(30, 40)]
        [TestCategory("Testing the position of the node")]
        [TestMethod]
        public void EnterAfterParticualarPositionTest(int value, int position)
        {
            //Arrange
            LinkedList list = new LinkedList();
            //Act
            int expected = 40;
            int actual = list.InsertParticularPosition(30, 40);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
