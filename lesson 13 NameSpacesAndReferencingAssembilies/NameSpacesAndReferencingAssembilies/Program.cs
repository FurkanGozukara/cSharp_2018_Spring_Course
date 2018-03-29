using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClassLibraryComposeDLL;
using Trial1;
using Trial2;

namespace Trial1
{
    public static class MainMethod
    {
        public static void Read() { }
    }
}

namespace Trial2
{
    public static class MainMethod
    {
        public static void Read() { }
    }
}

namespace NameSpacesAndReferencingAssembilies
{
    class Program
    {
        //it is possible that single name is shared between many classes in .NET class library
        //namespace solves this ambiguity 
        //while you might know which version of the class you intented
        //the C# compiler tries to resolve version of class
        //for example streamreader is not resolved by default
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //StreamReader reader = new  StreamReader("");
            //namespace can contain other namespaces

            //System.IO.StreamReader reader = new System.IO.StreamReader("");

            //too deep of a nesting structure add complexity
            //so it is better to try using as few as necessary namespaces 
            //using statement enables access all of its methods and classes
            //MainMethod.Read(); this is ambiguous 

            //default namespace can be changed from solution explorer
            //right click name of the application and click properties
            //change default namespace
            //this may be necessary for advanced programmers when there is a solution that has multiple projects
            //so it is rather for larger project

            //the next topic is adding references to assembilies
            //DLL files

            //we can right click system refence and see its properties
            //when we want to use some library that .NET does not have, we add its reference and use it
            //first a reference to that library need to be added to the project to use that library

            string source = DownloadWeb.DownloadWebPage("https://www.toros.edu.tr");

            //show adding system references and assemblies as well from add reference
            //additional DLL files need to be distributed with your EXE
        }
    }
}
