namespace OOPConcepts
{
    internal class InterfaceDemo
    {
        public InterfaceDemo() {

            ImplementationClass1 obj1 = new ImplementationClass1();
            //Using obj1 we can only call Add method
            obj1.Add(10, 20);
            //We cannot call Sub method
            //obj1.Sub(100, 20);
            ImplementationClass2 obj2 = new ImplementationClass2();
            //Using obj2 we can call both Add and Sub method
            obj2.Add(10, 20);
            obj2.Sub(100, 20);
            ((ITestInterface2)obj1).Sub(100, 20);
            Console.ReadKey();
        }
        interface ITestInterface1
        {
            void Add(int num1, int num2);
           // void Sub(int num1, int num2);
        }
        interface ITestInterface2 : ITestInterface1
        {
            void Sub(int num1, int num2);
        }
        public class ImplementationClass1 : ITestInterface1
        {
            //Implement only the Add method
            public void Add(int num1, int num2)
            {
                Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
            }
        }
        public class ImplementationClass2 : ITestInterface2
        {
            //Implement Both Add and Sub method
            public void Add(int num1, int num2)
            {
                Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
            }
            public void Sub(int num1, int num2)
            {
                Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
            }
        }
        public class ImplementationClass : ITestInterface1
        {
            //Interface Method Implementation
            public void Add(int num1, int num2)
            {
                Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
            }
            //This method purely belongs to ImplementationClass
            public void Sub(int num1, int num2)
            {
                Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
            }
        }
    }
}
