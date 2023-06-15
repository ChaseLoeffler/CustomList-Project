using CustomList;

namespace CustomList_Tests
{
    [TestClass]
    public class MinusOperatorOverloadMethodTests
    {
        [TestMethod]
        public void MinusOperatorOL_SubtractingListsFromEachOtherFirstListIsLonger_ItemsFromSecondListAreRemovedFromFirstList()
        {
            //Arrange
            CustomList<int> oneList = new();
            CustomList<int> twoList = new();
            //Act
            oneList.Add(1);
            oneList.Add(2);
            oneList.Add(3);
            oneList.Add(1);
            oneList.Add(2);
            oneList.Add(3);
            oneList.Add(1);
            oneList.Add(2);

            twoList.Add(3);
            twoList.Add(4);
            twoList.Add(3);
            twoList.Add(4);
            CustomList<int> newList = oneList - twoList;

            string result = newList.ToString();

            //Assert
            Assert.AreEqual("1, 2, 1, 2, 1, 2", result);
        }
        [TestMethod]
        public void MinusOperatorOL_SubtractingListsFromEachOtherSecondListIsLonger_ItemsFromSecondListAreRemovedFromFirstList()
        {
            //Arrange
            CustomList<int> oneList = new();
            CustomList<int> twoList = new();
            //Act
            oneList.Add(1);
            oneList.Add(2);
            oneList.Add(3);
            oneList.Add(1);
            oneList.Add(2);
            oneList.Add(3);
            oneList.Add(1);
            oneList.Add(2);

            twoList.Add(3);
            twoList.Add(4);
            twoList.Add(3);
            twoList.Add(4);
            CustomList<int> newList = twoList - oneList;

            string result = newList.ToString();

            //Assert
            Assert.AreEqual("4, 4", result);
        }
        [TestMethod]
        public void MinusOperatorOL_SubtractingListsFromEachOtherSecondListIsEmpty_ListIsUnchanged()
        {
            //Arrange
            CustomList<int> oneList = new();
            CustomList<int> twoList = new();
            //Act
            oneList.Add(1);
            oneList.Add(2);
            oneList.Add(3);
            oneList.Add(1);
            oneList.Add(2);
            oneList.Add(3);
            oneList.Add(1);
            oneList.Add(2);

            CustomList<int> newList = oneList - twoList;

            string result = newList.ToString();

            //Assert
            Assert.AreEqual("1, 2, 3, 1, 2, 3, 1, 2", result);
        }
        [TestMethod]
        public void MinusOperatorOL_SubtractingListsFromEachOther_OnlyTheFirstInstanceOfAValueIsRemoved()
        {
            //Arrange
            CustomList<int> oneList = new();
            CustomList<int> twoList = new();
            //Act
            oneList.Add(3);
            oneList.Add(3);
            oneList.Add(3);
            
            twoList.Add(1);
            twoList.Add(2);
            twoList.Add(3);
           
            CustomList<int> newList = oneList - twoList;

            string result = newList.ToString();

            //Assert
            Assert.AreEqual("3, 3", result);
        }
    }
}
