﻿namespace DataStructure_LinkedList
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
            linkedList.Display();
           
            linkedList.Search(40);
            linkedList.DeleteElement();
            linkedList.Size();
            Console.ReadLine();
        }
    }
}
