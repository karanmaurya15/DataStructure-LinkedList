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
        public int count = 1;
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
        public void InsertElement(int data)
        {
            int position;
            position = count + 1;
            
            Node newNode = new Node(data);
            Node prev = null;
            Node current = this.head;
            while (current != null && count <= position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newNode.next = prev.next;
            prev.next = newNode;
            Console.WriteLine("\n{0} inserted at position {1}", newNode.data, position);
        }
        public int Search(int value)
        {
            Node node = this.head;

            while (node != null)
            {
                if (node.data == value)
                {
                    Console.WriteLine("\n\nThe " + value + " is at Node : " + count);
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public void DeleteElement()
        {
            int position = count; //count used from pervious mathod
            Node temp = this.head;
  
            for (int i = 1; temp != null && i < position-1; i++)
            {
                temp = temp.next;
            }
            Node next = temp.next.next;
            temp.next = next;
            Console.WriteLine("\nValue from position {0} is deleted. ", position);
        }
        internal void Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            Console.Write("\nFinal Linked List is : ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("\nSize of LinkedList is :-" + " " + count);
        }
        internal void SortList()
        {
            if (head == null)
                return;
            else
            {
                int store;
                Node temp = head;
                Node temp1 = null;
                while (temp != null)
                {
                    temp1 = temp.next;
                    while (temp1 != null)
                    
                    {
                        if (temp.data.CompareTo(temp1.data) > 0)
                        {
                            store = temp.data;
                            temp.data = temp1.data;
                            temp1.data = store;
                        }
                        temp1 = temp1.next;
                    }
                    temp = temp.next;
                }
            }

        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Console.Write("Linked List :- ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
