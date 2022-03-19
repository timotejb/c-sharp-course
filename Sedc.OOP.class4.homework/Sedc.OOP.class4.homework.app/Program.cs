using System;

namespace Sedc.OOP.class4.homework.app
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Please input your date of birth in this format: dd-mm-yyyy");
            //string birth = Console.ReadLine();
            //Console.WriteLine(AgeCalculator(birth));

            Console.WriteLine(Palindrome("Timi"));
            Console.WriteLine(Digits("a1b9c2d8e3f7g9h"));
            Console.WriteLine(Vowels("a1b9c2d8e3f7g9h"));
            // Console.WriteLine(GreatesValue({ 1, 2, 3, 4}));
            string sentence = string.Empty;
            Console.WriteLine("type in a sentence");
            sentence = Console.ReadLine();
            Console.WriteLine(ViceVerca(sentence));
            
        }
        //homework 1
        public static int AgeCalculator(string birth)
        {
            DateTime birthday = DateTime.Parse(birth);
            DateTime currentDay = DateTime.Today;
            //ne ispagja tochno ako ushe ne ti bil rodendenot
            return currentDay.Year - birthday.Year;
        }

        //homework extra
        //task 1
        public static bool Palindrome(string word)
        {
            char[] letters = word.ToCharArray();

            string reverse = string.Empty;
            for (int i = letters.Length - 1; i >= 0; i--)
            {
                reverse = reverse + letters[i];

            }
            string wordFinal = word.ToLower();
            string reverseFinal = reverse.ToLower();
            if (wordFinal == reverseFinal)
            {
                return true;
            }
            else
                return false;
        }
        //task 2
        public static int GreatesValue(int[] arr)
        {


            int maxValue = arr[0];
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                if (maxValue < arr[i])
                {
                    maxValue = arr[i];
                }
            }
            return maxValue;
        }
        //task 3
        public static int Vowels(string str)
        {
            str = str.ToLower();
            char[] str1 = str.ToCharArray();
            int counter = 0;
            for (int i = 0; i <= str1.Length-1; i++)
            {
                if (str1[i] == 'a' || str1[i] == 'o' || str1[i] == 'e' || str1[i] == 'i' || str1[i] == 'u')
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int Digits(string str)
        {
            char[] str1 = str.ToCharArray();
            int counter = 0;
            for (int i = 0; i <= str1.Length-1; i++)
            {
                if (str1[i] == '1' || str1[i] == '2' || str1[i] == '3' || str1[i] == '4' || str1[i] == '5' || str1[i] == '6' || str1[i] == '7' || str1[i] == '8' || str1[i] == '9' || str1[i] == '0')
                {
                    counter++;
                }
            }
            return counter;
        }
        //task 4
        public static string ViceVerca (string sentence)
        {
            char[] sentence1 = sentence.ToCharArray();
            for (int i =0; i <= sentence1.Length - 1; i++)
            {
                if (char.IsLower(sentence[i])) 
                {
                    sentence1[i] = char.ToUpper(sentence1[i]);
                }
                else if (char.IsUpper(sentence1[i]))
                {
                   sentence1[i]= char.ToLower(sentence1[i]);
                }
            }
            string sentence2 = sentence1.ToString();
            return sentence2; //vo konzola vrakja System.Char[];
        }

        //task 5
        
        //task 6
        public static int Substrings (string str)
        {
            return 0;
        }
        //task 7
        public static int ResultOfRaisingInteger (int a, int b)
        {
            Console.WriteLine("Type in the number to be powered");
            string a1 = Console.ReadLine();
            Console.WriteLine(a + " to the power of ? :");
            string b1 = Console.ReadLine();
            a = int.Parse(a1);
            b = int.Parse(b1);
            for(int i = 1; i<b; i++)
            {
                a *= a;
            }
            return a;
        }

    }
    
}
