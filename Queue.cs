using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Algorithms
{
    public class Queue
    {
        public void runQueue()
        {
            // Create a queue 
            // Using Queue class 
            System.Collections.Queue my_queue = new System.Collections.Queue();

            // Adding elements in Queue 
            // Using Enqueue() method 
            my_queue.Enqueue("GFG");
            my_queue.Enqueue("Geeks");
            my_queue.Enqueue("GeeksforGeeks");
            my_queue.Enqueue("geeks");
            my_queue.Enqueue("Geeks123");

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                    my_queue.Count);

            // Checking if the element is 
            // present in the Queue or not 
            if (my_queue.Contains("GeeksforGeeks") == true)
            {
                Console.WriteLine("Element available...!!");
            }
            else
            {
                Console.WriteLine("Element not available...!!");
            }

            // Obtain the topmost element of my_queue 
            // Using Dequeue method 
            Console.WriteLine("Topmost element of my_queue"
                         + " is: {0}", my_queue.Dequeue());


            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            // Obtain the topmost element of my_queue 
            // Using Peek method 
            Console.WriteLine("Topmost element of my_queue is: {0}",
                                                   my_queue.Peek());
            // After Dequeue method 
            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            // Remove all the elements from the queue 
            my_queue.Clear();

            // After Clear method 
            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            Console.ReadLine();
        }
    }
}
