using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)//triggered when the application starts up
        {
            int[] numbers = new int[5];
            //arrays are 0 based very important, so first element is 0, second element is 1
            numbers[0] = 3;
            numbers[1] = 5;
            numbers[2] = 7;//the third element of the numbers is 7
            numbers[3] = 9;
            numbers[4] = 11;
            //  numbers[5] = 32;//this would throw error System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            // the arrays can not be shrinked or expanded once initilized they are immutable 

            Console.WriteLine(numbers[1].ToString()); //  Console.WriteLine(numbers[1]);

            numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };//this also works and the array size would be 9

            string[] arrayWords = new string[] { "a", "b", "c" };

            foreach (var word in arrayWords)
            {
                Console.WriteLine(word);
            }

            string message = "Help people to live happily. " +
                "Life is meaningless without helping each other.";

            char[] characters = message.ToCharArray();
            Array.Reverse(characters);

            foreach (var gg in characters)
                Console.Write(gg);

            Console.WriteLine("\n"+characters.Length);

            Console.Read();
        }
    }
}
