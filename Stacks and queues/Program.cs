using System;
using System.Collections.Generic;

namespace Stacks_and_queues
{
    internal class Program
    {
        //TODO - fix so that all orders Ids are shown
        static Order[] ReceiveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                    new Order(1,23),
                    new Order(2, 12),
                    new Order(5, 2)
            };
            return orders;
        }
        static Order[] ReceiveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                    new Order(3, 3),
                    new Order(4, 7),
                    new Order(6, 2)
            };
            return orders;
        }

        static void Main(string[] args)
        {
            #region Queue
            Queue<Order> queue = new Queue<Order>();
            
            foreach (Order o in ReceiveOrdersFromBranch1())
            {
                queue.Enqueue(o);                
            }
            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                queue.Enqueue(o);
            }

            while (queue.Count > 0)
            {
                Order currentOrder = queue.Dequeue();
                currentOrder.ProcessOrder();
            }

            #endregion
            #region Stack
            //int[] testArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Stack<int> myStack = new Stack<int>();

            //// print items from array in reverse order using stack

            //for (int i = 0; i < testArray.Length-1; i++)
            //{
            //    myStack.Push(i);
            //    Console.Write(myStack.Peek() + " ");                
            //}
            //Console.WriteLine();

            //while (myStack.Count > 0)
            //{
            //    Console.Write(myStack.Pop() + " "); 
            //}
            #endregion
        }

    }
}
