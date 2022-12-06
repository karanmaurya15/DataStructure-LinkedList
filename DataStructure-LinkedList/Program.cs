namespace DataStructure_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Data Structure Program\n");

            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            Console.WriteLine();
            linkedList.Search(30);
            linkedList.InsertElement(40);
           // Console.Write("\nNew ");
            linkedList.Display();
            Console.ReadLine();
        }
    }
}
