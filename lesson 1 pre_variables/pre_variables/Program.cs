using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pre_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            // we are asking .NET run time to allocate space sufficient enough to hold integer variables
            // int is the keyword for c# to hold values between -2^31 <> 2^31 , 2,147,483,648
            int y;

            x = 12;
            y = x + 29;

            Console.WriteLine(y);

            string myFirstName; // created a bucket in memory that can hold string values
            
            //camel case locally stored variable
            myFirstName = "Furkan";

            string myfirstname;// since case sensitive it is another variable

            Console.WriteLine(myFirstName);

            string mySecondName = "Gözükara";
            Console.WriteLine(mySecondName);

            var schoolName = "Toros";

            //c# compiler that turns code into .NET assembly is smart enough to figure out what that variable is going to be used
            //var keyword has to be always initialized 

            Console.WriteLine(schoolName);

            //how to convert data types

            //you cant treat integer variable as string or string variable as integer since they have different buckets in memory

            int gg = 33;
            string wp = "WP";
            string result = gg + wp;//.NET is smart enough to treat integer as string and concatenate them 
            //implict data conversation but this is not very preffered
        
            // this code is also equals to
            result = gg.ToString() + wp;
            //this above is implicit data conversion and it is preffered
            Console.WriteLine(result);

            //  int secondGG = gg + wp;//this doesnt work because .NET can not possibly know that the string can be always converted into integer

            //so we do implicit conversion

            //string number1 = "home";
            //int number2 = 142;
            //int result2 = int.Parse(number1) + number2;//this throws error since home can not be converted into an integer

            //Console.WriteLine(result2);


            string number3 = "66";
            int number4 = 33;
            int result3 = int.Parse(number3) + number4;//this works and it is being 99

            Console.WriteLine(result3);

            //alternatively this can be also used

            string convertAgain = "111";
            int number5 = 110;
            int result4 = Convert.ToInt32(convertAgain) + number5;
            Console.WriteLine(result4);

            Console.ReadLine();
        }
    }
}
