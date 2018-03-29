using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";//this is under class program means we are defining a field

        private static string _name;//this is also a field

        //static members are accessable accross all methods of that class
        //static members are accessable accross entire program without instancing 

        public int nonStaticMember { get; set; }

        //this is a property
        public static string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                if (_name == "0")
                    _name = "default";
            }
        }


        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //i is defined in the beginning of for loop
            //Console.WriteLine(i); this gives error
            //the name i doesnt exists in this scope
            //the variable is defined in for statement code block

            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = (i * i).ToString();

                if (i == 9)
                {
                    string gg = "99";
                }
                //Console.WriteLine(gg);//this gives error since out of its instanced scope
            }

            Console.WriteLine("outside of the for loop value j is " + j);
            Console.WriteLine("outside of the for loop value k is " + k);

            Name = "try";

            Console.WriteLine(Name);

            Name = "0";

            Console.WriteLine(Name);

            Program myProg1 = new Program();
            myProg1.nonStaticMember = 3;
            //myProg1.Name = "gg";//gives error since static

            helperMethod();


            //now time to understand accesbility modifiers public and private
            //these are used for encapsulation , preventing methods and variables to be used in an un-intended ways
            //private means method can be call by any of the method inside the same class but not outside of the class

            PrivatePublicExample.printHelloPublic();//only this available
            PrivatePublicExample.myPublicProp = 77;
            PrivatePublicExample.callPrintPrivate();
            //so consumers are not aware of the private methods printPrivate etc
            //hiding the implamantation and exposing the presentation

            //if method or variable is public, make the first letter big letter
            //if method or variable is private, make first letter smaller
            //make rest of the name camel case for example PublicFunction privateFunction

            //when we are developing our applications, we should strive to provide
            //consumers most clean and straightforward presentation by hiding
            //inner workings of the methods and classes

            //there is also protected accessibility provider
            //the protected methods and propertiers are only available to derived classes

            Console.ReadLine();
        }

        static void helperMethod()
        {
            Console.WriteLine("value of k is " + k + " called from helper method");
        }


        static class PrivatePublicExample
        {
            private static void printHello()
            {
                Console.WriteLine("Hello");
                myPrivateProp = 11;
                myPublicProp = 22;
                Console.WriteLine("public {0}, private {1}", myPublicProp, myPrivateProp);
            }

            public static void printHelloPublic()
            {
                Console.WriteLine("Hello Public");
                myPrivateProp = 33;
                myPublicProp = 44;
                Console.WriteLine("public {0}, private {1}", myPublicProp, myPrivateProp);
            }

            private static void printPrivate()
            {
                Console.WriteLine("printing public val: " + myPublicProp);
            }

            public static void callPrintPrivate()
            {
                printPrivate();
            }

            private static int myPrivateProp { get; set; }
            public static int myPublicProp { get; set; }

        }

        public class BaseClass
        {
            protected int myValue = 0;
            public int PublicMyVal = 0;
            private int privVal = 0;
        }

        public class DerivedClass1 : BaseClass
        {
            void Access()
            {
                BaseClass baseObject = new BaseClass();

                // Error CS1540, because myValue can only be accessed by
                // classes derived from BaseClass.
                // baseObject.myValue = 5;  
                baseObject.PublicMyVal = 5;

                //baseObject.privVal = 5;//error no one can access other than inner methods of BaseClass

                // OK, accessed through the current derived class instance
                myValue = 5;
            }
        }
    }
}
