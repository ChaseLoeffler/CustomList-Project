﻿using CustomList;

namespace CustomList_Tests
{
    [TestClass]
    public class RemoveMethodTest
    {
        [TestMethod]
        public void RemoveMethod_RemoveOneItem_CountDecrementsByOne()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("Hello");
            myList.Add("is");
            myList.Remove("Hello");
            //Assert
            Assert.AreEqual(1, myList.Count);
        }
        [TestMethod]
        public void RemoveMethod_RemoveOneItem_MethodReturnsTrueWhenItemIsRemoved()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("Hello");
            myList.Add("is");
            bool test = myList.Remove("Hello");
            //Assert
            Assert.AreEqual(true,test);
        }
        [TestMethod]
        public void RemoveMethod_RemoveOneItemNotInList_CountDoesNotDecrement()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("Hello");
            myList.Add("is");
            myList.Remove("Banana");
            //Assert
            Assert.AreEqual(2, myList.Count);
        }
    }
}
