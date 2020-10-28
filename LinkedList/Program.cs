using System;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Append(70);
            list.Display();
            Console.WriteLine("On inserting 30 at 2nd position");
            list.Insert(2, 30);
            list.Display();
        }
    }
}
