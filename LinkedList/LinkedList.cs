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
    }
}
