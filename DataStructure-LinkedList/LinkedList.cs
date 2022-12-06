using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_LinkedList
{
    internal class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List", node.data);
        }
        public Node InsertElement(int data)
        {
            int position = 2;
            int count = 1;

            Node neweNode = new Node(data);
            Node prev = null;
            Node current = this.head;           
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            neweNode.next = prev.next;
            prev.next = neweNode;
            return this.head;
        }
        public void PopFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("\nList is Empty");
            }
            this.head = this.head.next;
            Console.WriteLine("\nRemoved first node");
        }
        public void PopLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("\nLinked List Empty");
            }
            if (head.next == null)
            {
                Console.WriteLine("\nLinked List Empty");
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            Console.WriteLine("\nRemoved Last Node");
        }
    
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Console.Write("\nLinked List :- ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
