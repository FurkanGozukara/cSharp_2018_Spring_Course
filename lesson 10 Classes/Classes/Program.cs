using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Program
    {
        //classes are containers of related methods
        //console class lets us to access methods that are related to console
        //the methods are needed to be put into correct code blocks , inside related class code blocks
        //for example Main method is put in inside class Program code blocks class Program  {  }
        //virtually everthing in c# .NET framework is a class or part of a class
        //learning the everything about classes is topic of object oriented programming
        //we will rather focus on utilizing .NET framework classes and our simple classes

        static void Main(string[] args)
        {
            GraphicCard myNewCard = new GraphicCard();
            //instance of a class is an object , object is not a class or class is not an object. 
            //class is a blue print. in the real world we can use same blue print to build many houses
            //we can use same pattern to build many of the same thing
            //same is true with classes. each time we compose an instance of a class, we do the same
            //new keyword is like a factory and car is like the blueprint

            myNewCard.Make = "Nvidia";//we are setting properties here
            myNewCard.Model = "GTX 1070";
            myNewCard.GPUMhz = 1683;
            myNewCard.RamMemory = 8192;

            //we are getting properties here
            Console.WriteLine("make: {0}, model: {1}, GPU mhz: {2}, ram memory: {3} mb", myNewCard.Make,
                myNewCard.Model, 
                myNewCard.GPUMhz,
                myNewCard.RamMemory);

            Console.WriteLine("market value of the graphic card is: ${0:N}", determineGraphicCardValue(myNewCard));

            Console.WriteLine("market value of the graphic card is: ${0}", myNewCard.DetermineGraphicCardValue());

            Console.WriteLine("make: {0}, model: {1}, GPU mhz: {2}, ram memory: {3} mb, market value: {4:C}", myNewCard.Make,
            myNewCard.Model,
            myNewCard.GPUMhz,
            myNewCard.RamMemory,
            myNewCard.DetermineGraphicCardValue());

            Console.ReadLine();

        }

        //helper method
        private static double determineGraphicCardValue(GraphicCard myCard)
        {
            if (myCard.GPUMhz < 1000)
                return 3000;
            else
                return 4500;
        }

    }


    //lets assume that we have cars and we want to put everything about cars into single class
    //we set and get the properties of the classes
    //a method is something that the class can do
    //to define a property we can code snip type prob and hit tab tab
    //int is highlted and it is type of our property

    //we are here composing a new data type a custom class
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

        public double DetermineGraphicCardValue()
        {
            //this allows us to access all of the public and private members of the current instance
            if (this.GPUMhz < 1000)
                return 1200;
            else
                return 2500;
        }
    }
}
