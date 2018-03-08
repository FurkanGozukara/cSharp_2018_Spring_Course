using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //i++ is actually i = i + 1
            for (int i = 0; i < 10; i++) // type for and double click tab - it is called as code snippets
            {
                Console.WriteLine(i.ToString());

                if(i==7)
                {
                    //use debug to see how the application behaves
                    Console.WriteLine("found 7 and break the loop");
                    break;
                }
            }

            for (int myValue = 0; myValue < 21321; myValue++)//hit tab again to change variable name
            {

            }

            Console.ReadLine();
        }
    }
}
