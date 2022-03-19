using System;

namespace Sedc._3tiChas.excercisesAndHomework.app
{
    class Program
    {
        static void Main(string[] args)
       {
////////////////////            //excercise 1
////////////////////            Console.WriteLine("Excercise 1, please input a number: ");
////////////////////            string input = Console.ReadLine();
////////////////////            int a = int.Parse(input);

////////////////////            for (int i = 1; i <= a; i++)
////////////////////            {
////////////////////                Console.WriteLine(i);
////////////////////            }
////////////////////            Console.WriteLine("Please input another number: ");
////////////////////            string input1 = Console.ReadLine();
////////////////////            int a1 = int.Parse(input1);

////////////////////            if (a1 >= 1)
////////////////////            {
////////////////////                for (int i = a; i >= 1; i--)
////////////////////                {
////////////////////                    Console.WriteLine(i);
////////////////////                }
////////////////////            }
////////////////////            else if (a1 <= 1)
////////////////////            {
////////////////////                for (int i = a; i <= 1; i++)
////////////////////                {
////////////////////                    Console.WriteLine(i);
////////////////////                }
////////////////////            }

////////////////////            //excercise 2
////////////////////            Console.WriteLine("Excercise 2, please input a number: ");
////////////////////            string input2 = Console.ReadLine();
////////////////////            int a2 = int.Parse(input2);
////////////////////            for (int i = 1; i <= a2; i++)
////////////////////            {
////////////////////                if (i % 2 == 0)
////////////////////                {
////////////////////                    Console.WriteLine(i);
////////////////////                }
////////////////////            }
////////////////////            Console.WriteLine("Please input another number: ");
////////////////////            string input3 = Console.ReadLine();
////////////////////            int a3 = int.Parse(input3);
////////////////////            for (int i = 1; i <= a3; i++)
////////////////////            {
////////////////////                if (i % 2 != 0)
////////////////////                {
////////////////////                    Console.WriteLine(i);
////////////////////                }
////////////////////            }
////////////////////            //excercise 3
////////////////////            Console.WriteLine("Excercise 3, please input a number:");
////////////////////            string input4 = Console.ReadLine();
////////////////////            int a4 = int.Parse(input4);
////////////////////            for (int i = 1; i <= a4; i++)
////////////////////            {
////////////////////                if (i < 100)
////////////////////                {
////////////////////                    if (i % 3 != 0 && i % 7 != 0)
////////////////////                    {
////////////////////                        Console.WriteLine(i);
////////////////////                    }
////////////////////                    else
////////////////////                        Console.WriteLine("");
////////////////////                }
////////////////////                else
////////////////////                {
////////////////////                    Console.WriteLine("The limit is reached");
////////////////////                    break;



////////////////////                }
////////////////////            }
////////////////////            //excercise 4
////////////////////            Console.WriteLine("=-=-=-=-=-=-=-=-=- Excercise 4 =-=-=-=-=-=-=-=-=-");

////////////////////            string[] words = { "Timotej", "Bojarovski", "20", "Sedc", "C#" };
////////////////////            double[] decimals = { .23, .34, .499999, .50, .001 };
////////////////////            char[] characters = { 'a', 'b', 'c', 'd', 'e', 'f' };
////////////////////            bool[] booleans = { true, false, false, true, true };
////////////////////            int[] arr1 = { 234, 456 };
////////////////////            int[] arr2 = { 123, 2344 };
            //int[] arr = { arr1[], arr2[]};

            //excercise 5
            Console.WriteLine("=-=-=-=-=-=-= Excercise 5 =-=-=-=-=-=-=-=");
            int[] array = { 0, 0, 0, 0, 0 };
            int sum = 0;
            for( int i = 0; i< array.Length; i++)
            {
                Console.WriteLine("Input a number for the array:");
                string input6 = Console.ReadLine();
                array[i] = int.Parse(input6);
                sum = sum + array[i];
            }
            Console.WriteLine("The sum of the numbers you inputed into the array is " + sum);
            //excercise 6
            string[] names = { };
            Console.WriteLine("Type in a name:");
            char ask = 'y';
            while (ask == 'y')
            {
                for (int i = 0; i <= 10000; i++)
                {

                    Console.WriteLine("Do you want to write in another name? Y/N");
                    string ask1 = Console.ReadLine();
                    ask = char.Parse(ask1);
                    if (ask == 'n')
                    {

                            break;
                    }
                    Console.WriteLine("Type your name in");
                    string name = Console.ReadLine();
                    names[i] = name;                       
                }
            }
            for ( int i = 0; i<= names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
