using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectLifeTime
{
    class ClassCopyRef
    {
        static void Main2(string[] args)
        {
            Cars myCar = new Cars();
            myCar.Speed = 2353543;
            myCar.Price = 224354432;

            myCar.Price.ToString();

            List<Cars> myCarsList = new List<Cars> { myCar };
            Cars[] myCarsArrayList = { myCar };



            Console.WriteLine("Speed: {0:N} , Price: {1:C} , Weight: {2:N}", myCar.Speed, myCar.Price, myCar.Weight);

            Cars myCar2 = new Cars(2000, 3000, 5000);

            // myCarsArrayList[1] = myCar2;

            myCarsList.Add(myCar2);

            myCarsList[1].Speed = 100000;

            int a = 33;
            int b = a;
            b = 55;
            string c = "55";
            string d = c;
            d = "66";
            changeValue(ref a);
            Console.WriteLine("a: {0}, b: {1}, c: {2}, d: {3}", a, b, c, d);

            printCar(myCar2);

            Console.WriteLine("Speed: {0:N} , Price: {1:C} , Weight: {2:N}", myCar2.Speed, myCar2.Price, myCar2.Weight);

            myCar2.Cars2(99, 999, 9999);

            Console.WriteLine("Speed: {0:N} , Price: {1:C} , Weight: {2:N}", myCar2.Speed, myCar2.Price, myCar2.Weight);

            Cars.printFunction.printValues(myCar2);

            Console.ReadLine();
        }

        static void changeValue(ref int c)
        {
            c = 77;
        }

        static void printCar(Cars myCar)
        {
            Cars myTempCar = myCar.deepCopy();
            myTempCar.Price = 333;
            Console.WriteLine(myTempCar.Price);
        }

        class Cars
        {
            public Cars deepCopy()
            {
                Cars tempCar = new Cars();
                tempCar.Price = this.Price;
                tempCar.Speed = this.Speed;
                tempCar.Weight = this.Weight;
                return tempCar;
            }

            public int Speed { get; set; }
            public int Price { get; set; }
            public int Weight { get; set; }

            public Cars()
            {
                Weight = 1000;
            }

            public Cars(int speed, int price, int weight)
            {
                this.Price = price;
                this.Speed = speed;
                this.Weight = weight;
            }

            public void Cars2(int speed, int price, int weight)
            {
                this.Price = price;
                this.Speed = speed;
                this.Weight = weight;
            }

            public static class printFunction
            {
                public static void printValues(Cars tempCar)
                {
                    Console.WriteLine("Speed: {0:N} , Price: {1:C} , Weight: {2:N}", tempCar.Speed, tempCar.Price, tempCar.Weight);
                }
            }
        }
    }
}
