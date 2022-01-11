using System;
using LinkedListLibrary;

namespace LinkedListLibraryTest
{
    public class LinkedListLibraryTest
    {
        static void Main(string[] args)
        {
            var intList = new List<int>(); // create integer List container
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int num4 = 40;
            int num5 = 50;

            // use List insert methods       
            intList.InsertAtFront(num1);
            intList.InsertAtFront(num2);
            intList.InsertAtBack(num3);
            intList.InsertAtBack(num4);
            intList.InsertAtFront(num5);

            intList.Display();

            Console.WriteLine($"Last element of integer linked list: {intList.GetLastNode()}");
            Console.WriteLine($"Minimum element of integer linked list: {intList.Minimum()}");
            Console.WriteLine("---------------------------------------");

            var doubleList = new List<double>(); // create double List container
            double doubleNum1 = 5.32;
            double doubleNum2 = 13.66;
            double doubleNum3 = 32.09;
            double doubleNum4 = 45.78;
            double doubleNum5 = 77.41;

            // use List insert methods       
            doubleList.InsertAtFront(doubleNum1);
            doubleList.InsertAtFront(doubleNum2);
            doubleList.InsertAtBack(doubleNum3);
            doubleList.InsertAtBack(doubleNum4);
            doubleList.InsertAtBack(doubleNum5);

            doubleList.Display();

            Console.WriteLine($"Last element of double linked list: {doubleList.GetLastNode()}");
            Console.WriteLine($"Minimum element of double linked list: {doubleList.Minimum()}");
            Console.WriteLine("---------------------------------------");

            // just an extra testing
            var stringList = new List<String>(); // create string List container

            // use List insert methods       
            stringList.InsertAtFront("apple");
            stringList.InsertAtFront("orange");
            stringList.InsertAtBack("pineapple");
            stringList.InsertAtBack("peach");
            stringList.InsertAtBack("mango");

            stringList.Display();

            Console.WriteLine($"Last element of string linked list: {stringList.GetLastNode()}");
            Console.WriteLine($"Minimum element of string linked list: {stringList.Minimum()}");
        }
    } // end main
} // end namespace
