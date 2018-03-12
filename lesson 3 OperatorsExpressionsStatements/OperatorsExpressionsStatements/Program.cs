using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, gg; //decleration statements : complete thoughts

            //Assigment operator
            x = 4;
            y = 3;
            z = 2;
            gg = 1;

            //There are many mathematical operators

            //Addition operator
            x = 5 + 4; // these are expressipon and they consists of operators and operands 

            //Subtraction operator
            x = 32 - 23;

            //Multiplication operatpr
            x = 12 * 5;
            Console.WriteLine();
            // () method operator
            // . member accessor operator
            // =  assigment operator 
            // == test for equality operator

            //equality operator
            if (x == y) { }

            //greator operator
            if (x > y) { }

            //less than operator
            if (x < y) { }

            //greator or equal
            if (x >= y) { }

            //less than or equal
            if (x <= y) { }

            //condintional AND operator
            if (x == y && y == gg) { }

            //condintional OR operator
            if (x == y || y == gg) { }


            //inline conditional operator
            x = (y == gg) ? 12 : 32; // == ? :

            if (y == gg)
            {
                x = 12;
            }
            else
            {
                x = 32;
            }

            //member access and method invocation
            Console.WriteLine("gg");


            if (x == y) gg = 323;

            if (x == y)
            {
                gg = 323;



            }

            //white spaces and empty lines doesnt matter in c# 

            int c = x + y; // syntax matter 

        }
    }
}
