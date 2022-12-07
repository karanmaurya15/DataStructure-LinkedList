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
            linkedList.Add(40);
            linkedList.Add(70);
            Console.WriteLine("\n~~~~~~~~~~Linked List Before Sorting~~~~~~~~~");
            linkedList.Display();

            Console.WriteLine("\n\n~~~~~~~~~~~Linked List After Sorting~~~~~~~~~");        
            linkedList.SortList();
            linkedList.Display();
            Console.ReadLine();
        }
    }
}
