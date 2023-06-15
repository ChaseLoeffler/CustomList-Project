namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Further testing to ensure tests dont pass while expected result does not occur.

            CustomList<int> oneList = new();
            CustomList<int> twoList = new();

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
        }
    }
}