using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            // defining a new stack
            Stack<int> myStack = new Stack<int>();

            // add item to stack
            myStack.Push(1);


            // Check what element is a the top of the stack
            Console.WriteLine("Top value of the stack is: {0}", myStack.Peek());
            myStack.Push(3);
            Console.WriteLine("Top value of the stack is: {0}", myStack.Peek());
            myStack.Push(34567);
            Console.WriteLine("Top value of the stack is: {0}", myStack.Peek());

            // Remove item at the top of the stack (impossible to pop from an empty stack
            if(myStack.Count > 0)
            {
                int myStackPopedItem = myStack.Pop();
                Console.WriteLine("Poped item is: {0}", myStackPopedItem);

            }
            Console.WriteLine("Top value of the stack is: {0}", myStack.Peek());

            do
            {
                myStack.Pop();
            }
            while (myStack.Count > 0);

            if (myStack.Count == 0)
            {
                Console.WriteLine("Empty stack");
            }
            else
            {
                Console.WriteLine("Top value of the stack is: {0}", myStack.Peek());

            }


            // reversing array
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Stack<int> newStack = new Stack<int>();

            for(int i = numbers.Length - 1; i > 0; i--)
            {
                newStack.Push(numbers[i]);
                Console.WriteLine("Last item added: {0}", numbers[i]);
                Console.WriteLine("Top of stack is: {0}", newStack.Peek());

            }




        }
    }
}
