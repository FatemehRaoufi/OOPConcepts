using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    /// <summary>
    /// Both these approaches can be used for extending the functionalities of an existing class whereas, 
    /// in the case of inheritance, we call the methods defined in the old and new classes by using the object of the new class whereas, 
    /// in the case of extension methods, we call the old and new methods by using the object of the old class.
    /// 
    /// Sometimes inheritance is not possible. 
    /// That means if the class is declared using the sealed modifier,then we cannot create a derived class from the sealed.
    /// But we can extend the functionality of sealed class using the Extension Method.
    /// </summary>
    internal class ExtensionMethods
    {
        public ExtensionMethods() {
            OldClass obj = new OldClass();
            obj.OldClassTest1();
            obj.OldClassTest2();
            //Calling Extension Methods
            obj.NewClassTest3();
            obj.NewClassTest4(10);
            obj.NewClassTest5();
            Console.ReadLine();
        }
        //Sample12 Method:
        public void StringExstentionMethod()
        {
            string myWord = "Welcome to Dotnet Tutorials Extension Methods Article";
            int wordCount = myWord.GetWordCount();
            Console.WriteLine("string : " + myWord);
            Console.WriteLine("Count : " + wordCount);
            Console.Read();
        }
        //Sample3: LINQ uses Extension Methods Effectively
        public void LinqExtensionMethods()
        {
            List<int> intList = new List<int>()
            {
                10, 20, 30, 40, 50
            };

            //If you go to the definition of Where method, then you will see that
            //it is implemented as an extension method
            var List1 = intList.Where(x => x > 20).ToList();

            Console.ReadKey();
        }
    }

    /// <summary>
    /// 1.Extension methods must be defined only under the static class. So NewClass is a static class.
    /// 2.the extension method should be created as a static method whereas once the method is bound with another class, the method changes into non-static. 
    /// So,in New class, all three methods are declared as static only.
    /// 3.The first parameter of an extension method is known as the binding parameter which should be the name of the class
    /// 4.An extension method can have only one binding parameter and that should be defined in the first place on the parameter list.
    /// 5.If required, an extension method can be defined with normal parameters also starting from the second place of the parameter list. (NewClassTest4)
    /// </summary>

    //Sample1: OldClass & NewClass
    public class OldClass
    {
        public int x = 100;
        public void OldClassTest1()
        {
            Console.WriteLine("Method one: " + this.x);
        }
        public void OldClassTest2()
        {
            Console.WriteLine("Method two: " + this.x);
        }
    }
    public static class NewClass
    {
        public static void NewClassTest3(this OldClass O)
        {
            Console.WriteLine("Method Three");
        }
        public static void NewClassTest4(this OldClass O, int x)
        {
            Console.WriteLine("Method Four: " + x);
        }
        public static void NewClassTest5(this OldClass O)
        {
            Console.WriteLine("Method Five:" + O.x);
        }
    }
    //.......................................................
    //Sample12 Class: Extension Method Real-Time Example
    public static class StringExtension
    {
        public static int GetWordCount(this string inputstring)
        {
            if (!string.IsNullOrEmpty(inputstring))
            {
                //Split the string by a space
                string[] strArray = inputstring.Split(' ');
                return strArray.Count();
            }
            else
            {
                return 0;
            }
        }
    }
    //----------------------------------------------
   
}


//https://dotnettutorials.net/lesson/extension-methods-csharp/
