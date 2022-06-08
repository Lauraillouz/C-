using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            // define a queue
            Queue<int> queue = new Queue<int>();

            // add item at the end of the queue
            queue.Enqueue(1);

            // print the element in front of the queue
            Console.WriteLine("Value at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("Value at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(3);

            // get rid of first element in the queue
            int dequeuedItem = queue.Dequeue();
            Console.WriteLine("You dequeued {0}", dequeuedItem);
            Console.WriteLine("Value at the front of the queue is: {0}", queue.Peek());





            Queue<Order> ordersQueue = new Queue<Order>();

            foreach(Order o in ReceivedOrdersFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in ReceivedOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            // as long as the queue is not empty
            while (ordersQueue.Count > 0)
            {
                // remove the order at the front of the queue and store it in a variable 
                Order currentOrder = ordersQueue.Dequeue();
                // process the order
                currentOrder.ProcessOrder();

            }


            // Method that creates an array and returns it
            static Order[] ReceivedOrdersFromBranch1()
            {
                // create new orders
                Order[] orders = new Order[]
                {
                    new Order(1, 5),
                    new Order(2, 10),
                    new Order(6, 6),
                };
                return orders;
            }

            static Order[] ReceivedOrdersFromBranch2()
            {
                Order[] orders = new Order[]
                {
                    new Order(3, 7),
                    new Order(4, 2),
                    new Order(5, 5),
                };
                return orders;
            }


        }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        // constructor
        public Order(int id, int quantity)
        {
            this.OrderId = id;
            this.OrderQuantity = quantity;
        }


        // print message on the screen that the order was processed
        public void ProcessOrder()
        {
            Console.WriteLine("Order {0} processed!", OrderId);
        }
    }


}
