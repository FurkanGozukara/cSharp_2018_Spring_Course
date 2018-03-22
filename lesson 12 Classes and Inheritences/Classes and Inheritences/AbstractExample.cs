using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_and_Inheritences
{
    public static class AbstractExample
    {
        public static void printCarDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the Vehicle's details {0}", vehicle.FormatMe());
        }

        public abstract class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public abstract string FormatMe();
        }

        public class Car : Vehicle
        {
            public override string FormatMe()
            {
                return string.Format("{0} - {1} - {2} - {3}",
                    this.Make,
                    this.Model,
                    this.Year,
                    this.Color);
            }
        }

        public class Truck : Vehicle
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

       sealed public class Airplane : Vehicle
        {
            public int Speed { get; set; }

            public override string FormatMe() //override keyword is necessary
            {
                return string.Format("{0} - {1} - {2} Towing Units",
                    this.Make,
                    this.Model,
                    this.Speed);
            }
        }

        //sealed public class Jet : Airplane//this gives error
        //{
        //    public int Speed { get; set; }

        //    public override string FormatMe() //override keyword is necessary
        //    {
        //        return string.Format("{0} - {1} - {2} Towing Units",
        //            this.Make,
        //            this.Model,
        //            this.Speed);
        //    }
        //}

         public class SportCar : Car
        {
            public int Speed { get; set; }

            public override string FormatMe() //override keyword is necessary
            {
                return string.Format("{0} - {1} - {2} Speed",
                    this.Make,
                    this.Model,
                    this.Speed);
            }
        }

        //static feature  forces you to do not create an instance of object or the class
        //sealed feature forces you to do not inherit that class
        //abstract feature forces you to create overrided method
    }
}
