using CustomList;

namespace CustomList_Tests
{
    [TestClass]
    public class ToStringMethodTests
    {
        [TestMethod]
        public void ToStringMethod_CreatListOfStrings_ReturnsAListOfStrings()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("Hello");
            myList.Add("is");
            string result = myList.ToString();
            //Assert
            Assert.AreEqual("Hello, is.", result);
        }
    }
}
