﻿using System;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList");
            LinkedList list = new LinkedList();
            list.Add(30);
            list.Add(56);
            list.Add(70);
            list.Display();
        }
    }
}
