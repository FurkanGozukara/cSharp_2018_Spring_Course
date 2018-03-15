using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            /*what is happening whenever this line of code is executed?
            .NET framework runtime has to go and compose a spot in a computers memory large enough to hold instance of GraphicCard card
            so computer memory has address like street address where it temporarly stores values of variables during the life time of a variable or in this case of an object
            so.NET framework creates a place in memory large enough for the particular data type
            in this case an instance of the class GraphicCard
            it takes note of the address where it put that new instance of the GraphicCard class
            and it then serves back to you the programmer so you can back to that information in memory
            and you store that reference in your variable in this case called myNewCard
            so myNewCard simply holds an address a reference to the instance of a GraphicCard class
            in the computer's memory
            whenever you need to work with that instance of GraphicCard class you just use the
            myNewCard identifier .NET framework takes care of the rest for you
            and it gives you the illusion that you are actually working with the
            object itself but in reality you are just holding onto a reference to an address
            in the computer's memory
            an anology for this can be holding a handle of a bucket
            we can use handle to hold bucket
            if we let go the handle, the we can not access the bucket any longer
            because .NET framework once in a while goes and counts the references
            and deletes the objects from the computer's memory that has no reference anymore
            this process is called as garbage collection
            */

            GraphicCard myNewCard = new GraphicCard();


            //set properties
            myNewCard.Make = "Nvidia";//we are setting properties here
            myNewCard.Model = "GTX 1070";
            myNewCard.GPUMhz = 1683;
            myNewCard.RamMemory = 8192;

            //2 references to the same object in memory
            //we basically attached another handle to the bucket
            //so we can use either one of the handle to retreive data in the bucket
            //so this is like string attached to a ballon. we can attach many strings
            //but once the last one is cut of, it goes to the sky
            GraphicCard myOtherCard = myNewCard;

            //so when the program goes away from the scope of that thread
            //the references are deleted and the objects in memory is collected
            //by garbage collector later

            myNewCard = null;
            myOtherCard = null;
            //when will actuall objects deleted from memory is not precise
            //however there may be situations where these references are holding
            //important system resources etc. in such cases, we want to use deterministic finalization
            //this is topic of later lessons

            //whenever we create an instance of a class we use method operator
            myNewCard = new GraphicCard();
            //which means classes have constructors. allows developers to to pass parameters
            //or do operations during the initilization stage of the object

            Console.WriteLine("original price "+ 
                myNewCard.OriginalPrice.ToString("C", CultureInfo.GetCultureInfo("en-GB")));

            GraphicCard.PrintNumber();

            //understanding notion of overloading and usage of static are crucial
            //make sure that method signature is different when coding several overloaded methods

            Console.ReadLine();

        }
    }

    class GraphicCard
    {
        public string Make { get; set; } // get and set are so-called auto property
                                         //the above auto property is equal to below
        private string model;
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int RamMemory { get; set; }
        public int GPUMhz { get; set; }
        public double OriginalPrice { get; set; }

        public GraphicCard()
        {
            this.OriginalPrice = 1000;
        }

        public GraphicCard(string make, string model, int ramMemory, int gpuMHZ, int originalPrice)
        {
            Make = make;
            Model = model;
            RamMemory = ramMemory;
            GPUMhz = gpuMHZ;
            OriginalPrice = originalPrice;
        }

        //parameter names doesnt affect the method signature
        //only parameter types and the number of parameters affect
        //public GraphicCard(string otherParamter, string model, int ramMemory, int gpuMHZ, int originalPrice)
        //{
        //    Make = otherParamter;
        //    Model = model;
        //    RamMemory = ramMemory;
        //    GPUMhz = gpuMHZ;
        //    OriginalPrice = originalPrice;
        //}

        //if we do not compose any any constructor what happens?
        //it would be equal to below

        //implict default constructer
        //public GraphicCard()
        //{
         
        //}

        public double DetermineGraphicCardValue()
        {
            //this allows us to access all of the public and private members of the current instance
            if (this.GPUMhz < 1000)
                return 1200;
            else
                return 2500;
        }

        //lets talk about keyword static
        //we use Console.WriteLine but we never create any instance of anything
        //these are only possible because these classes are defined as static
        //some classes would require creating an instance of a class while some would not
        //when the c# keyword Static is used
     
        //example

        public static void PrintNumber()
        {
            Console.WriteLine("hello this is called from a static non instantiated class");
        }
    }
}
