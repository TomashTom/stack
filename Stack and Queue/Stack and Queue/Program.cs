﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            Console.WriteLine(queue.Peek());


            Console.ReadLine();
            
        }
    }
}
