namespace DataStructure_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Data Structure Program\n");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(70);

            Console.WriteLine("\nLinked List after insertion of new element");
            linkedList.InsertElement(30);
            linkedList.Display();
        }
    }
}
