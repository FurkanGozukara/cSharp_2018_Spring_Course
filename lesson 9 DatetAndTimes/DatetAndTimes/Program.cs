using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace DatetAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            Console.WriteLine(Thread.CurrentThread.CurrentCulture);
            Console.WriteLine("DateTime.ToString() " + myValue.ToString());
            Console.WriteLine("DateTime.ToLongDateString() " + myValue.ToLongDateString());
            Console.WriteLine("DateTime.ToLongTimeString() " + myValue.ToLongTimeString());
            Console.WriteLine("DateTime.ToOADate() " + myValue.ToOADate());
            Console.WriteLine("DateTime.ToShortDateString() " + myValue.ToShortDateString());
            Console.WriteLine("DateTime.ToShortTimeString() " + myValue.ToShortTimeString());
            Console.WriteLine("DateTime.ToUniversalTime() " + myValue.ToUniversalTime());
            Console.WriteLine("DateTime.ToLocalTime() " + myValue.ToLocalTime());
            Console.WriteLine();
            Console.WriteLine("DateTime.Year " + myValue.Year);
            Console.WriteLine("DateTime.Month " + myValue.Month);
            Console.WriteLine("DateTime.Day " + myValue.Day);
            Console.WriteLine("DateTime.Hour " + myValue.Hour);
            Console.WriteLine("DateTime.Minute " + myValue.Minute);
            Console.WriteLine("DateTime.Second " + myValue.Second);
            Console.WriteLine("DateTime.Millisecond " + myValue.Millisecond);
            Console.WriteLine("DateTime.Ticks " + myValue.Ticks);
            Console.WriteLine();
            Console.WriteLine("DateTime.DayOfYear " + myValue.DayOfYear);
            Console.WriteLine("DateTime.DayOfWeek " + myValue.DayOfWeek);
            Console.WriteLine();
            Console.WriteLine("Current date is " + DateTime.Now.ToShortTimeString() + " *** 3 hours 13 minutes later it will be " + DateTime.Now.AddHours(3).AddMinutes(13).ToShortTimeString());


            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("tr-TR");
            Console.WriteLine(Thread.CurrentThread.CurrentCulture);

            Console.WriteLine("DateTime.ToString() " + myValue.ToString());
            Console.WriteLine("DateTime.ToLongDateString() " + myValue.ToLongDateString());
            Console.WriteLine("DateTime.ToLongTimeString() " + myValue.ToLongTimeString());
            Console.WriteLine("DateTime.ToOADate() " + myValue.ToOADate());
            Console.WriteLine("DateTime.ToShortDateString() " + myValue.ToShortDateString());
            Console.WriteLine("DateTime.ToShortTimeString() " + myValue.ToShortTimeString());
            Console.WriteLine("DateTime.ToUniversalTime() " + myValue.ToUniversalTime());
            Console.WriteLine("DateTime.ToLocalTime() " + myValue.ToLocalTime());
            Console.WriteLine();
            Console.WriteLine("DateTime.Year " + myValue.Year);
            Console.WriteLine("DateTime.Month " + myValue.Month);
            Console.WriteLine("DateTime.Day " + myValue.Day);
            Console.WriteLine("DateTime.Hour " + myValue.Hour);
            Console.WriteLine("DateTime.Minute " + myValue.Minute);
            Console.WriteLine("DateTime.Second " + myValue.Second);
            Console.WriteLine("DateTime.Millisecond " + myValue.Millisecond);
            Console.WriteLine("DateTime.Ticks " + myValue.Ticks);
            Console.WriteLine();
            Console.WriteLine("DateTime.DayOfYear " + myValue.DayOfYear);
            Console.WriteLine("DateTime.DayOfWeek " + myValue.DayOfWeek);
            Console.WriteLine();
            Console.WriteLine("Current date is " + DateTime.Now.ToShortTimeString() + " *** 3 hours 13 minutes later it will be " + DateTime.Now.AddHours(3).AddMinutes(13).ToShortTimeString());

            Console.WriteLine();
            Console.WriteLine();
            DateTime myJobStartDate = new DateTime(2018, 3, 1, 9, 0, 0);
            Console.WriteLine("My job start date is " + myJobStartDate.ToString());

            DateTime torosUniversityOpenDate = DateTime.Parse("23/07/2009");
            TimeSpan openSince = DateTime.Now.Subtract(torosUniversityOpenDate);
            Console.WriteLine("TimeSpan.ToString() " + openSince.ToString());
            Console.WriteLine("TimeSpan.TotalDays " + openSince.TotalDays.ToString("N"));
            Console.WriteLine("TimeSpan.TotalHours " + openSince.TotalHours.ToString("N"));
            Console.WriteLine("TimeSpan.TotalMinutes " + openSince.TotalMinutes.ToString("N"));
            Console.WriteLine("TimeSpan.TotalSeconds " + openSince.TotalSeconds.ToString("N"));
            Console.WriteLine("TimeSpan.TotalMilliseconds " + openSince.TotalMilliseconds.ToString("N"));
            Console.WriteLine("TimeSpan.Days " + openSince.Days);
            Console.WriteLine("TimeSpan.Hours " + openSince.Hours);
            Console.WriteLine("TimeSpan.Minutes " + openSince.Minutes);
            Console.WriteLine("TimeSpan.Seconds " + openSince.Seconds);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("TimeDiff.TotalDays " + (DateTime.Now - torosUniversityOpenDate).TotalHours.ToString("N"));


            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine(Thread.CurrentThread.CurrentCulture);

            Console.WriteLine("TimeSpan.ToString() " + openSince.ToString());
            Console.WriteLine("TimeSpan.TotalDays " + openSince.TotalDays.ToString("N"));
            Console.WriteLine("TimeSpan.TotalHours " + openSince.TotalHours.ToString("N"));
            Console.WriteLine("TimeSpan.TotalMinutes " + openSince.TotalMinutes.ToString("N"));
            Console.WriteLine("TimeSpan.TotalSeconds " + openSince.TotalSeconds.ToString("N"));
            Console.WriteLine("TimeSpan.TotalMilliseconds " + openSince.TotalMilliseconds.ToString("N"));
            Console.WriteLine("TimeSpan.Days " + openSince.Days);
            Console.WriteLine("TimeSpan.Hours " + openSince.Hours);
            Console.WriteLine("TimeSpan.Minutes " + openSince.Minutes);
            Console.WriteLine("TimeSpan.Seconds " + openSince.Seconds);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("TimeDiff.TotalDays " + (DateTime.Now - torosUniversityOpenDate).TotalHours.ToString("N"));


            Stopwatch sw = Stopwatch.StartNew();
            doSomething();
            sw.Stop();

            Console.WriteLine("Time taken to complete doSomething method is: {0} seconds", sw.Elapsed.TotalSeconds);

            Console.ReadLine();
        }

        static void doSomething()
        {
            for (int i = 0; i < 999999999; i++)
            {
                string temp = "temp";
            }
        }
    }
}
