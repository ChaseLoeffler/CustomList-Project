using CustomList;

namespace CustomList_Tests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void AddMethod_AddOneItem_CountIncreasesByOne()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("hello");
            //Assert
            Assert.AreEqual(1, myList.count);
        }
        [TestMethod]
        public void AddMethod_AddOneItem_FirstItemAtIndexZero()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("Hello");

            //Assert
            Assert.AreEqual("Hello", myList[0]);

        }
        [TestMethod]
        public void AddMethod_AddTwoItems_SecondItemAtIndexOne()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("Hello");
            myList.Add("World");


            //Assert
            Assert.AreEqual("World", myList[1]);

        }
        [TestMethod]
        public void AddMethod_ExceedCapacity_CapacityDoubles()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("hello");
            myList.Add("world");
            myList.Add("is");
            myList.Add("it");
            myList.Add("me");

            //Assert
            Assert.AreEqual(8, myList.capacity);
        }
        [TestMethod]
        public void AddMethod_ExceedCapacity_OriginalItemsPersistInSameIndex()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("hello");
            myList.Add("world");
            myList.Add("is");
            myList.Add("it");
            myList.Add("me");

            //Assert
            Assert.AreEqual("is", myList[2]);
        }
    }
}