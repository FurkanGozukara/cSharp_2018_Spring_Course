using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pre_decision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type something and hit the enter key");
            string userValue;
            userValue = Console.ReadLine();
            Console.WriteLine("You have typed: " + userValue); // string concatenation

            Console.WriteLine("Choose a number to see what it displays, options are 1, 2, 3");
            userValue = Console.ReadLine();

            if (userValue == "1")
            {
                Console.WriteLine("You have chosen 1");
            }
            else
            if (userValue == "2")
            {
                Console.WriteLine("You have chosen 2");
            }

            if (userValue == "3")
            {
                Console.WriteLine("You have chosen 3");
            }

            Console.WriteLine("Choose a number to see what it displays, options are 7, 8");
            userValue = Console.ReadLine();

            if (userValue == "7")
            {
                Console.WriteLine("You have chosen 7");
            }
            else
            if (userValue == "8")
            {
                Console.WriteLine("You have chosen 8");
            }
            else
            {
                Console.WriteLine("You have chosen none of the options");
            }



            Console.WriteLine("Choose a number to see what it displays, options are 7, 8");
            userValue = Console.ReadLine();
            string message = "";
            if (userValue == "7")
                message = "You have chosen 7";
            else
            if (userValue == "8")
                message = "You have chosen 8";
            else
                message = "You have chosen none of the options";

            Console.WriteLine(message);


            message = (userValue == "7") ? "GG it is 7" : "It is not 7";
            Console.WriteLine("Message is : {0} and second message is: {1}", message, "NULL");

            Console.ReadLine();
        }
    }
}
