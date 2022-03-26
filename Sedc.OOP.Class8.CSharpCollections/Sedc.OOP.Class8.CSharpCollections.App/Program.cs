using System;
using System.Collections;
using System.Collections.Generic;
namespace Sedc.OOP.Class8.CSharpCollections.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[4];
            string[] strArray2 = new string[] { "Hello", "World" };
            goThroughCollection(strArray2, "array");

            Array.Resize(ref strArray2, strArray2.Length + 1);
            strArray2[^1] = "!";
            goThroughCollection(strArray2, "array");

            #region Lists
            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(9);
            numbers.Add(7);
            numbers.Remove(9);
        
            Console.WriteLine("List count is: " + numbers.Count);
            goThroughCollection(numbers, "numbers");
            #endregion

            #region Dictionary
            Dictionary<string, string> dictionaryOne = new Dictionary<string, string>();
            dictionaryOne.Add("song1", "Winds of change");
            dictionaryOne.Add("song2", "Enter Sandman");
            dictionaryOne.Add("animal", "Dog");
            goThroughCollection(dictionaryOne, "of Dictionary");
            //dictionaryOne.Add("animal", "Dog");  => key must always be different from other keys ("animal")

            Dictionary<int, string> dictionaryTwo = new Dictionary<int, string>
            {
                {1, "Hello" },
                {2, "World" },
                {3, "!" }
            };

            Console.WriteLine(dictionaryOne["song2"]);
            Console.WriteLine(dictionaryTwo[2]); //iako lichi na index, toa e kluchot 2 , samo pechat e
            Console.WriteLine("Length: " + dictionaryTwo.Count);
                        //<kluch, tip>
            Dictionary<int, MyType> myTypeDictionary = new Dictionary<int, MyType>();
            Dictionary<string, List<string>> bandongsDictionary = new Dictionary<string, List<string>>();

            foreach(KeyValuePair<int, string> KeyValue in dictionaryTwo)
            {
                Console.WriteLine("================");
                Console.WriteLine(dictionaryTwo[KeyValue.Key]);
            }
            #endregion

            #region Queue and Stack
            Console.WriteLine("=-=-=-=-=-=-= Queue =-=-=-=-=-=-=-=");
            Queue<int> someQueue = new Queue<int>();
            someQueue.Enqueue(3);
            someQueue.Enqueue(4);
            someQueue.Enqueue(7);
            someQueue.Enqueue(10);
            int firstElement = someQueue.Dequeue(); //go vadish prviot element od kolekcijata i ja koristish vrednosta
            Console.WriteLine(firstElement);
            goThroughCollection(someQueue, "Queue");
            //Console.WriteLine(someQueue[1]); ne mozhesh da koritish indeks so stack i queue
            Console.WriteLine("using the .peek() method");
            Console.WriteLine(someQueue.Peek());
            Console.WriteLine("Length: " + someQueue.Count);

            Console.WriteLine("=-=-=-=-=-=-= Stack =-=-=-=-=-=-=");

            Stack<string> someStack = new Stack<string>(); //last in first out
            someStack.Push("hey");
            someStack.Push("Hello");
            someStack.Push("Hi");
            someStack.Push("Zdravo");
            goThroughCollection(someStack, "Stack");

            string item = someStack.Pop();
            Console.WriteLine($"using pop mehtod {item}");
            Console.WriteLine($"using peek method {someStack.Peek()}");
            #endregion
        }

        public static void goThroughCollection(IEnumerable collection, string name)
        {
            Console.WriteLine("Collection {0} items", name);
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
        }
        public class MyType
        {

        }
    }
}