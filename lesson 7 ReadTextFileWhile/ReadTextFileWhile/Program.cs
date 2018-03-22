using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //the C# compiler can not resolve StreamReader to its full name so we need to add library reference
           // System.IO.StreamReader myReader = new System.IO.StreamReader("Values.txt");
            StreamReader myReader = new StreamReader("Values.txt");
            string line = "";

            while (line != null) // there is no pre set number of iteration , we dont know how many times we need to iterate
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            Console.WriteLine("");

            foreach (var line2 in File.ReadLines("Values.txt"))
            {
                Console.WriteLine(line2);
            }

            Console.WriteLine("");

            string[] lines = File.ReadAllLines("Values.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }

            List<string> myList = File.ReadAllLines("Values.txt").ToList();

            foreach (var item in myList.ToList())
            {
                myList.Add("32");
                Console.WriteLine("my list: " + item);
            }

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            myReader.Close();//if you forget to close, the file may remain open and this can cause errors if someone else access the file

            Console.Read();

        }
    }
}
