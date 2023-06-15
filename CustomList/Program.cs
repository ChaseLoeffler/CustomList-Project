namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Further testing to ensure tests dont pass while expected result does not occur.
            //CustomList<int> myList = new();
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(1);

            //myList.Remove(1);

            //string n = myList.ToString();
            //Console.WriteLine(n);

            //Arrange
            CustomList<int> oneList = new();
            CustomList<int> twoList = new();
            //Act
            oneList.Add(1);
            oneList.Add(2);
            oneList.Add(1);
            oneList.Add(2);

            twoList.Add(1);
            twoList.Add(2);
            twoList.Add(1);
            twoList.Add(2);
            CustomList<int> combinedLists = oneList - twoList;

            combinedLists.Add(1);

            string n = combinedLists.ToString();
            Console.WriteLine(n);
        }
    }
}