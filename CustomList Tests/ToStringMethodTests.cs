using CustomList;

namespace CustomList_Tests
{
    [TestClass]
    public class ToStringMethodTests
    {
        [TestMethod]
        public void ToStringMethod_CreatListOfStrings_ReturnsListAsStrings()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("Hello");
            myList.Add("is");
            string result = myList.ToString();
            //Assert
            Assert.AreEqual("Hello, is", result);
        }
        [TestMethod]
        public void ToStringMethod_CreatListOfInts_ReturnsListAsStrings()
        {
            //Arrange
            CustomList<int> myList = new();
            //Act
            myList.Add(1);
            myList.Add(2);
            string result = myList.ToString();
            //Assert
            Assert.AreEqual("1, 2", result);
        }
        [TestMethod]
        public void ToStringMethod_CreateEmptyList_ReturnsListAsEmptyString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            string result = myList.ToString();
            //Assert
            Assert.AreEqual("", result);
        }
        
    }
}
