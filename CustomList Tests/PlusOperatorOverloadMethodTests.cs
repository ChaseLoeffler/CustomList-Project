using CustomList;

namespace CustomList_Tests
{
    [TestClass]
    public class PlusOperatorOverloadMethodTests
    {
        [TestMethod]
        public void PlusOperatorOL_AddListTogetherFirstListIsLarger_ReturnsListsCombined()
        {
            //Arrange
            CustomList<int> oneList = new();
            CustomList<int> twoList = new();
            //Act
            oneList.Add(1);
            oneList.Add(2);
            oneList.Add(1);
            oneList.Add(2);
            oneList.Add(1);
            oneList.Add(2);
            oneList.Add(1);
            oneList.Add(2);

            twoList.Add(3);
            twoList.Add(4);
            twoList.Add(3);
            twoList.Add(4);
            CustomList<int> combinedLists = oneList + twoList;

            string result = combinedLists.ToString();

            //Assert
            Assert.AreEqual("1, 2, 1, 2, 1, 2, 1, 2, 3, 4, 3, 4",result);

        }
        [TestMethod]
        public void PlusOperatorOL_AddListTogetherSecondListIsLarger_ReturnsListsCombined()
        {
            //Arrange
            CustomList<int> oneList = new();
            CustomList<int> twoList = new();
            //Act
            oneList.Add(1);
            oneList.Add(2);
            oneList.Add(1);
            oneList.Add(2);

            twoList.Add(3);
            twoList.Add(4);
            twoList.Add(3);
            twoList.Add(4);
            twoList.Add(3);
            twoList.Add(4);
            twoList.Add(3);
            twoList.Add(4);

            CustomList<int> combinedLists = oneList + twoList;

            string result = combinedLists.ToString();

            //Assert
            Assert.AreEqual("1, 2, 1, 2, 3, 4, 3, 4, 3, 4, 3, 4",result);

        }
        [TestMethod]
        public void PlusOperatorOL_AddListTogetherFirstListIsEmpty_ResultIsUnchanged()
        {
            //Arrange
            CustomList<int> oneList = new();
            CustomList<int> twoList = new();
            //Act
            twoList.Add(3);
            twoList.Add(4);
            twoList.Add(3);
            twoList.Add(4);

            CustomList<int> combinedLists = oneList + twoList;

            string result = combinedLists.ToString();

            //Assert
            Assert.AreEqual("3, 4, 3, 4", result);

        }
        [TestMethod]
        public void PlusOperatorOL_AddListTogetherSecondListIsEmpty_ResultIsUnchanged()
        {
            //Arrange
            CustomList<int> oneList = new();
            CustomList<int> twoList = new();
            //Act
            oneList.Add(1);
            oneList.Add(2);
            oneList.Add(1);
            oneList.Add(2);

            CustomList<int> combinedLists = oneList + twoList;

            string result = combinedLists.ToString();

            //Assert
            Assert.AreEqual("1, 2, 1, 2", result);

        }

    }
}
