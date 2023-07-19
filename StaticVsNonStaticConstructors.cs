namespace OOPConcepts
{
    /// <summary>
    /// Constructors are responsible for initializing the fields or variables of a class. 
    /// Static Fields/Variables are initialized by static constructors 
    /// and non-static fields/variables are initialized by non-static or instance constructors in C#.
    /// </summary>
    public class StaticVsNonStaticConstructors
    {
        public static int x=10; //It is going to be initialized by static constructor
        int y; //It is going to be initialized by non-static constructor
        //Static Constructor
        static StaticVsNonStaticConstructors()
        {
            //This constructor initialized the static variable x with default value i.e. 0
            Console.WriteLine("Static Constructor is Called");
        }
        //Overloading not allowed:
        //static StaticVsNonStaticConstructors(int x)
        //{
        //    //This constructor initialized the static variable x with default value i.e. 0
        //    Console.WriteLine("Static Constructor is Called");
        //}
        //Non-Static Constructor
        public StaticVsNonStaticConstructors()
        {
            //This constructor initialized the static variable y with default value i.e. 0
            Console.WriteLine("Non-Static Constructor is Called");
        }
        public StaticVsNonStaticConstructors(int x)
        {
            //This constructor initialized the static variable y with default value i.e. 0
            Console.WriteLine("Non-Static Constructor is Called");
        }
    }
}
//https://dotnettutorials.net/lesson/static-vs-non-static-constructors-in-csharp/