using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_and_Inheritences
{
    class Program
    {
        static void Main(string[] args)
        {
            //.net framework class library is also called as base class library
            //we gonna talk about base classes in this lesson and especially about class inheritencce

            //never write the same code twice and never do copy and paste
            //for composing a class for trucks, we can borrow the all code of car class and override the parts
            //that we do not want

            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;
            //myCar.TowingCapacity = 1200; not available for Car

            printCarDetails(myCar);

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Color = "Black";
            myTruck.Year = 2006;
            myTruck.TowingCapacity = 1200;

            printCarDetails(myTruck);//this is possible because Truck is a type of Car
                                     //Car class is referred as the base class and the Truck class is referred as the derived class
                                     //Car class is the super class and the truck is the sub class
                                     //Car class is the parent class and the truck is the child class
                                     //All these terminologies are true
                                     //.NET framework library is the one massive collection of  all the base and derived classes collection
                                     //because it creates one flexible way of working with classes

            //one example is streamreader class
            //streamreader class utilizes class in file system class
            //go to https://msdn.microsoft.com/en-us/library/system.io.filestream(v=vs.110).aspx
            //it shows all its inheritences, constructers, methods, properties, some remarks, some examples and other related information
            //msdn microsoft developers network
            //you can see what a given class is derived from or what other classes are derived from it
            //click System.IO.Stream and see what other classes are derived from it


            //you can not create an instance of abstract class



            AbstractExample.Car myCar2 = new AbstractExample.Car();
            myCar2.Make = "abstract BMW";
            myCar2.Model = "abstract 745li";
            myCar2.Color = "abstract Black";
            myCar2.Year = 2105;

            AbstractExample.printCarDetails(myCar2);

            AbstractExample.Truck myTruck2 = new AbstractExample.Truck();
            myTruck2.Make = "abstract Ford";
            myTruck2.Model = "abstract F950";
            myTruck2.Color = "abstract Black";
            myTruck2.Year = 2106;
            myTruck2.TowingCapacity = 81200;

            AbstractExample.printCarDetails(myTruck2);//this is possible because Truck is a type of Car

            Console.ReadLine();


        }

        private static void printCarDetails(Car car)
        {
            Console.WriteLine("Here are the Car's details {0}", car.FormatMe());
        }

        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public virtual string FormatMe()//virtual means this method can be overrided
            {
                return string.Format("{0} - {1} - {2} - {3}",
                    this.Make,
                    this.Model,
                    this.Year,
                    this.Color);
            }

            //public abstract string FormatMe()//abstract means you have to override it and it cant be used
            //{
            //    return string.Format("{0} - {1} - {2} - {3}",
            //        this.Make,
            //        this.Model,
            //        this.Year,
            //        this.Color);
            //}
        }

        class Truck : Car //this is inheritence syntax
        {
            public int TowingCapacity { get; set; }

            public override string FormatMe() //override keyword is necessary
            {
                return string.Format("{0} - {1} - {2} Towing Units",
                    this.Make,
                    this.Model,
                    this.TowingCapacity);
            }
        }




    }
}
