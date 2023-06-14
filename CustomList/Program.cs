namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Further testing to ensure tests dont pass while expected result does not occur.
            CustomList<int> myList = new();
            myList.Add(1);
            myList.Add(2);
            myList.Add(1);
            myList.Add(2);
            myList.Add(1);

            myList.Remove(1);

            string n = myList.ToString();
            Console.WriteLine(n);

        }
    }
}