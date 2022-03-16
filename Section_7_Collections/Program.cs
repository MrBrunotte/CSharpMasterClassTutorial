using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Section_7_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // define a queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);

            // printing the element at the front of the queue, the first value will be shown (1)
            queue.Enqueue(5);
            queue.Enqueue(7);
            queue.Enqueue(6);
            queue.Enqueue(99);
            Console.WriteLine($"The value at the front of the queue is: {queue.Peek()}");
            queue.Enqueue(2);
            Console.WriteLine($"First value in the queue is: {queue.Peek()}");
            queue.Enqueue(3);
            // removes number 1
            int queueItem = queue.Dequeue();
            Console.WriteLine($"New first item now: {queue.Peek()}");
            Console.WriteLine($"\nFirst value in the queue is: {queue.Peek()}");

            while (queue.Count > 0)
            {
                Console.WriteLine($"The front value {queue.Dequeue()} was remove from the queue.");
                Console.WriteLine($"Current queue count is: {queue.Count}");
            }

            Console.WriteLine("\n#### EXAMPLE QUEUE ####");
            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order order in RecieveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(order);
            }
            foreach (Order order in RecieveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(order);
            }

            // as long as the order at the front of the que is not empty
            while (ordersQueue.Count>0)
            {
            // store it in a variable called currentOrder
            Order currentOrder = ordersQueue.Dequeue();
            //Processor the order
            currentOrder.processOrder();
            }

            Console.Read();
        }
        static Order[] RecieveOrdersFromBranch1()
        {
            // creating new orders
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,1)
            };
            return orders;
        }
        static Order[] RecieveOrdersFromBranch2()
        {
            // creating new orders
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            return orders;
        }
    }
    class Order
    {
        public int ID { get; set; }
        public int OrderQty { get; set; }
        public Order(int id, int orderQty)
        {
            ID = id;
            OrderQty = orderQty;
        }
        public void processOrder()
        {
            Console.WriteLine($"Order: {ID} processed!");
        }
    }
}
