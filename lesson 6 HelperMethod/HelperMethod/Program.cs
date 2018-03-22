using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethod
{
    class Program
    {
        private static string megaSecretFormula(int X, int Y)
        {
            //some cool stuff here
            return string.Format("{0} * {1} is {2}", X, Y, X * Y);
        }

        private static string megaSecretFormula(int X, int Y, int Z)//different signature // overloaded method
        {
            //some cool stuff here
            return string.Format("{0} * {1} * {2} is {3}", X, Y, Z, X * Y * Z);
            // return $"{X} * {Y} * {Z} is {X * Y * Z}"; 

        }

        private static void megaSecretFormula()
        {
            Console.WriteLine("this is void method that returns nothing");
        }

        static void Main(string[] args)
        {
            string myValue = superSecretFormula();
            Console.WriteLine(myValue);
            Console.WriteLine(megaSecretFormula(9, 9));
            Console.WriteLine(megaSecretFormula(3, 19, 23));
            megaSecretFormula();
            Console.Read();
        }

        //rather than the position in which class it is put is important
        //private means it can be only called within this class Program
        //main method is static we have to make this static as well
        //static means it doesn't need to be initialized like an object so it is not a member of any object
        //static and non static are rather topic of object oriented programming
        //string is the return type and it has to return defined type always
        //its name is naming convention and it is camel case. 
        //camel case is used to indicate that the formula or the variable is private in the scope

        private static string superSecretFormula()
        {
            //some cool stuff here
            if (3 == 3)
                return "hello world from helper method";
            else
                return 3.ToString();
        }

    
    }
}
