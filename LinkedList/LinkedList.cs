using System;
using System.Collections.Generic;
using System.Text;
namespace LinkedList
{
    class LinkedList
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                this.head = node;             
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                Node temp = head;
                while(temp != null)
                {
                    Console.WriteLine(" "+temp.data);
                    temp = temp.next;
                }
            }
        }
        public void Append(int data)
        {
            if(head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                Node node = new Node(data);
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void Insert(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node n = head, previous = head, after;
                for (int pos = 1; pos < position; pos++)
                {
                    n = n.next;
                    if (pos == position - 2)
                    {
                        previous = n;
                    }
                }
                after = n;
                previous.next = node;
                node.next = after;
            }
        }
    }
}
