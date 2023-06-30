using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPConcepts
{
    /// <summary>
    /// Here, we have created a class called Complex. Inside the Complex class, 
    /// we have created two integer-type private data members that are real and img. 
    /// Then we have created a parameterized constructor as public. 
    /// We can pass the two integer values as parameters to the constructor 
    /// and the constructor will assign those integer values to real and img private data members of the class.
    /// We have also provided some default values to the constructor arguments so that if the user doesn’t pass any values, 
    /// then the constructor will automatically assign 0 to real and img data members. 
    /// This constructor will work as a parameterized constructor as well as a non-parameterized constructor.
    /// 
    /// For learning operator overloading we have to learn two things. 
    /// First, how to write a function, and second, what should be the signature of a function. 
    /// Signature of a function we will show you afterward, first.

   /// <summary>
    internal class PolymorphismOperatorOverloading
    {
        public PolymorphismOperatorOverloading() {

            Complex c1 = new Complex(3, 7);
            c1.Display();
            Complex c2 = new Complex(5, 2);
            c2.Display();
            Complex c3 = Complex.Add(c1, c2);
            c3.Display();
            Console.ReadKey();
        }


    }
    public class Complex
    {
        private int real;
        private int img;
        public Complex(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }
        public static Complex Add(Complex c1, Complex c2)
        {
            Complex temp = new Complex();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex temp = new Complex();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;
        }
        public void Display()
        {
            Console.WriteLine($"{real} + i{img}");
        }
        
    };
}
//https://dotnettutorials.net/lesson/operator-overloading-in-csharp/