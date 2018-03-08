using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // string myString = "Go to your C:\ drive";// \ has a special meaning in strings
            string myString = "Go to your C:\\ drive"; // this will produce a single \
                                                       // \ character is an escape character

            Console.WriteLine(myString);

            // myString = "i always say "help others"";
            myString = "i always say \"help others\"";

            Console.WriteLine(myString);

            myString = "what if i need \n a new line?  ";

            Console.WriteLine(myString);
      


            //https://blogs.msdn.microsoft.com/csharpfaq/2004/03/12/what-character-escape-sequences-are-available/

            //string format allow us to merge strings inside other strings , like a template

            myString = string.Format("{0} vs {1}", "GG", "WP");
            Console.WriteLine(myString);

            myString = string.Format("{{{0} vs {1}}}", "GG", "WP");
            Console.WriteLine(myString);

            myString = string.Format("{0:C}", 223113.3);
            Console.WriteLine(myString);

            myString = string.Format("{0:N}", 2123232432.342);
            Console.WriteLine(myString);

            myString = string.Format("{0:P}", .4518);
            Console.WriteLine(myString);

            myString = string.Format("Phone number: {0:(##) ### #####}", 901234567);
            //it begins putting numbers with right side and goes to the left
            Console.WriteLine(myString);

            myString = "";

            for (int i = 0; i < 22; i++)
            {
               /// myString += i + "--";
                myString = myString + i + "--";
            }

            Console.WriteLine(myString);

            //when the strings are initialized they have constant lenght
            //so appending strings to each other each times, the .Net assembly composes a new string and it is very heavy operation

            StringBuilder myBuilder = new StringBuilder();
            for (int i = 0; i < 22; i++)
            {
                myBuilder.Append(i + "--");
            }
            Console.WriteLine(myBuilder.ToString());

            Console.OutputEncoding = Encoding.UTF8;

            myString = "so appending strings to each other each times, the .Net assembly composes a new string and it is very heavy operation";

            myString = myString.Substring(5, 25);//0 is first character just like arrays 0 based
            Console.WriteLine(myString);

            myString = myString.ToUpper();
            Console.WriteLine(myString);

            myString = myString.ToLower();
          
            myString = myString.ToUpper( new System.Globalization.CultureInfo("tr-TR"));
            Console.WriteLine(myString);

            myString = myString.Replace(" ", "--");
            Console.WriteLine(myString);

            myString = " shall we take a break?  ";
            Console.WriteLine(string.Format("before trim lenght {0}, after trim lenght {1}",
                myString.Length, 
                myString.Trim().Length));
            //trim method returns a string without leading and trailing empty spaces
            Console.Read();
        }
    }
}
