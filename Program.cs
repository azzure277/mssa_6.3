using System;
using System.Collections.Generic;

namespace mssa_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue<string> callQueue = new Queue<string>();

            // Enqueue callers
            callQueue.Enqueue("Helena");
            callQueue.Enqueue("Dennis");
            callQueue.Enqueue("Belinda");

            Console.WriteLine("Current Call Queue:");
            foreach (var caller in callQueue)
            {
                Console.WriteLine(caller);
            }

            // Dequeue callers
            Console.WriteLine("\nDequeuing callers:");
            while (callQueue.Count > 0)
            {
                string nextCaller = callQueue.Dequeue();
                Console.WriteLine($"Now serving: {nextCaller}");
            }
        }
    }
}
