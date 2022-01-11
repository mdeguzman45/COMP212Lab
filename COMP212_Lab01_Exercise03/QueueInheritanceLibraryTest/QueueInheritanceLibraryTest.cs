// Fig. 19.17: QueueTest.cs
// Testing class QueueInheritance.
using System;
using QueueInheritanceLibrary;
using LinkedListLibrary;

// demonstrate functionality of class QueueInheritance
namespace QueueInheritanceLibraryTest
{
    public class QueueTest
    {
        static void Main()
        {
            /* Start Queue Integer */
            QueueInheritance<int> intQueue = new QueueInheritance<int>();

            // create int objects to store in the queue
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int num4 = 40;
            int num5 = 50;

            Console.WriteLine("Integer Queue Implementation");
            // use method Enqueue to add items to queue
            intQueue.Enqueue(num1);
            intQueue.Display();
            intQueue.Enqueue(num2);
            intQueue.Display();
            intQueue.Enqueue(num3);
            intQueue.Display();
            intQueue.Enqueue(num4);
            intQueue.Display();
            intQueue.Enqueue(num5);
            intQueue.Display();

            // Console for Exercise 03
            Console.WriteLine($"Last item queued: {intQueue.GetLast()}");

            // use method Dequeue to remove items from queue
            object removedObject = null;

            // remove items from queue
            try
            {
                while (true)
                {
                    removedObject = intQueue.Dequeue();
                    Console.WriteLine($"{removedObject} dequeued");
                    intQueue.Display();
                }
            }
            catch (EmptyListException emptyListException)
            {
                // if exception occurs, write stack trace
                Console.Error.WriteLine(emptyListException.StackTrace);
            }

            /* End Queue Integer */

            /* Start Queue Double */
            QueueInheritance<double> doubleQueue = new QueueInheritance<double>();

            // create int objects to store in the queue
            double doubleNum1 = 7.34;
            double doubleNum2 = 14.62;
            double doubleNum3 = 36.27;
            double doubleNum4 = 53.95;
            double doubleNum5 = 87.23;

            Console.WriteLine("Double Queue Implementation");
            // use method Enqueue to add items to queue
            doubleQueue.Enqueue(doubleNum1);
            doubleQueue.Display();
            doubleQueue.Enqueue(doubleNum2);
            doubleQueue.Display();
            doubleQueue.Enqueue(doubleNum3);
            doubleQueue.Display();
            doubleQueue.Enqueue(doubleNum4);
            doubleQueue.Display();
            doubleQueue.Enqueue(doubleNum5);
            doubleQueue.Display();

            // Console for Exercise 03
            Console.WriteLine($"Last item queued: {doubleQueue.GetLast()}");

            // use method Dequeue to remove items from queue
            object doubleRemovedObject = null;

            // remove items from queue
            try
            {
                while (true)
                {
                    doubleRemovedObject = doubleQueue.Dequeue();
                    Console.WriteLine($"{doubleRemovedObject} dequeued");
                    doubleQueue.Display();
                }
            }
            catch (EmptyListException emptyListException)
            {
                // if exception occurs, write stack trace
                Console.Error.WriteLine(emptyListException.StackTrace);
            }

            /* End Queue Double*/
        }
    } // end QueueTest class
} //end namespace 
