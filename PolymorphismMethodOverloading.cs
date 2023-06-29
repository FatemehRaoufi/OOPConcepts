using System.Buffers.Text;
using System.Reflection;

namespace OOPConcepts
{
    /// <summary>
    /// Method Overloading means it is an approach to defining multiple methods under the class with a single name. 
    /// So, we can define more than one method with the same name in a class. 
    /// But the point that you need to remember the parameters of all those methods should be different (different in terms of number, type, and order of the parameters).
    /// </summary>
    internal class PolymorphismMethodOverloading
    {
        public PolymorphismMethodOverloading()
        { }


        public void OverloadingMethod()
        {
            Add(10, 20);
            Add(10.5f, 20.5f);
            Add("Pranaya", "Rout");
            Console.ReadKey();

        }
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }
        //--------------------------
        public void InheritanceBasedMethodOverloadingMethod()
        {
            Class2 obj = new Class2();
            obj.Add(10, 20);
            obj.Add(10.5f, 20.7f);
            obj.Add("Pranaya", "Rout");
            //Output:
            /*
             30
            31.2
            "Pranaya Rout"
             */
            Console.ReadKey();
        }
        //---------------------------------------

        public void ConstructorOverloadingMethod()
        {
            ConstructorOverloading obj1 = new ConstructorOverloading(10);
            obj1.Display();
            ConstructorOverloading obj2 = new ConstructorOverloading(10, 20);
            obj2.Display();
            ConstructorOverloading obj3 = new ConstructorOverloading(10, 20, 30);
            obj3.Display();
            Console.ReadKey();
        }
        //----------------------------------------
        public void RealtimeOverloadingMethod()
        {

            string ClassName = "Program";
            string MethodName = "Main";
            string UniqueId = Guid.NewGuid().ToString();
            Logger.Log(ClassName, MethodName, "Message 1");
            Logger.Log(UniqueId, ClassName, MethodName, "Message 2");
            Logger.Log("Message 3");
            try
            {
                int Num1 = 10, Num2 = 0;
                int result = Num1 / Num2;
                Logger.Log(UniqueId, ClassName, MethodName, "Message 4");
            }
            catch (Exception ex)
            {
                Logger.Log(ClassName, MethodName, ex);
            }

            Console.ReadKey();
        }
    }
    
    //----------------------------------

    /// <summary>
    /// Inheritance-Based Method Overloading in C#:
    /// A method that is defined in the parent class can also be overloaded under its child class. It is called Inheritance Based Method Overloading in C#. 
    /// See the following example for a better understanding. As you can see in the below code, 
    /// we have defined the Add method twice in the class Class1 and also defined the Add method in the child class Class1. 
    /// Here, notice every Add method takes different types of parameters.
    /// Note: To overload a parent class method under its child class the child class does not require any permission from its parent class.
    /// </summary>

    class Class1
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
    }
    class Class2 : Class1
    {
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }
    }
    //--------------------------------------------------
    /// <summary>
    /// Constructor Method Overloading in C#:
    /// At the following example, we are creating three different versions of the Constructor, 
    /// and each constructor takes a different number of parameters, and this is called Constructor Overloading in C#.
    /// </summary>
    class ConstructorOverloading
    {
        int x, y, z;
        public ConstructorOverloading(int x)
        {
            Console.WriteLine("Constructor1 Called");
            this.x = 10;
        }
        public ConstructorOverloading(int x, int y)
        {
            Console.WriteLine("Constructor2 Called");
            this.x = x;
            this.y = y;
        }
        public ConstructorOverloading(int x, int y, int z)
        {
            Console.WriteLine("Constructor3 Called");
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Display()
        {
            Console.WriteLine($"X={x}, Y={y}, Z={z}");
        }
    }
    //--------------------------------------------------------
    //Method Overloading Realtime Example using C# Language:
    /// <summary>
    /// Suppose, you are working on a real-time project. One of the mandatiory things that we need to do is logging. 
    /// Whenever a request comes, when a method call, we need to capture the request details, 
    /// we need to log the necessary information either on a text file or in the database. 
    /// Even when some exceptions occurred we also need to log the exception detail so that later we can verify the log and need to identify the reasons for the exception. 
    /// In the below example, we are creating a class called Logger with many overloaded versions of the Log method. 
    /// So, as per our requirement, we can call the appropriate method.
    /// </summary>
    public class Logger
    {
        public static void Log(string ClassName, string MethodName, string Message)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, ClassName: {ClassName}, MethodName:{MethodName}, Message:{Message}");
        }
        public static void Log(string uniqueId, string ClassName, string MethodName, string Message)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, UniqueId: {uniqueId}, ClassName: {ClassName}, MethodName:{MethodName}, Message:{Message}");
        }
        public static void Log(string Message)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, Message: {Message}");
        }
        public static void Log(string ClassName, string MethodName, Exception ex)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, ClassName: {ClassName}, MethodName:{MethodName}, Exception Message:{ex.Message}, \nException StackTrace: {ex.StackTrace}");
        }
        //You create many overloaded versions as per your business requirements
    }


}
//https://dotnettutorials.net/lesson/function-overloading-csharp/