using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Stack stack = new Stack();
            Queue queue = new Queue();
            Console.WriteLine("Welcome to Data Structures Programs");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Enter the Program to be executed : \n 1. Create Simple Linked List \n 2. Add in Reverse Order \n 3. Insert at Particular Position \n 4. Remove First node \n 5. Remove Last Node \n 6. Stack Push \n 7. Stack Peek and Pop \n 8. Enqueue \n 9. Dequeue \n 10. Search \n 11. Ability to Insert \n 12. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 2:
                        linkedList.AddInReverseOrder(70);
                        linkedList.AddInReverseOrder(30);
                        linkedList.AddInReverseOrder(56);
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.Add(56);
                        linkedList.Add(70);
                        linkedList.InsertAtParticularPosition(1, 30);
                        linkedList.Display();
                        break;
                    case 4:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirstNode();
                        Console.WriteLine("After removing the first node of Linked List : ");
                        linkedList.Display();
                        break;
                    case 5:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveLastNode();
                        Console.WriteLine("After removing the last node of Linked List : ");
                        linkedList.Display();
                        break;
                    case 6:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Display();
                        break;
                    case 7:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Display();
                        stack.Peek();
                        stack.Pop();
                        stack.Display();
                        stack.Peek();
                        stack.Pop();
                        stack.Display();
                        stack.Peek();
                        stack.Pop();
                        stack.Display();
                        break;
                    case 8:
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        queue.Display();
                        break;
                    case 9:
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        queue.Display();
                        queue.Dequeue();
                        queue.Display();
                        queue.Dequeue();
                        queue.Display();
                        queue.Dequeue();
                        queue.Display();
                        break;
                    case 10:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();
                        int search = linkedList.Search(30);
                        Console.WriteLine("The searched data is at position {0}", search);
                        break;
                    case 11:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();
                        int position = linkedList.Search(30);
                        position++;
                        linkedList.InsertAtParticularPosition(position, 40);
                        linkedList.Display();
                        break;
                    case 12:
                        flag = false;
                        break;
                }
            }            
        }
    }
}