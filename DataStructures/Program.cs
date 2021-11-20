using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Console.WriteLine("Welcome to Data Structures Programs");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Enter the Program to be executed : \n 1. Create Simple Linked List \n 2. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
            
        }
    }
}