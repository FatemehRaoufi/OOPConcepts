namespace OOPConcepts
{
    /// <summary>
    /*

  ** Abstract Methods in C#:
      That means the abstract method contains only the declaration, no implementation.
      But without writing the method body, if we end the method with a semicolon as follows, then it is called an Abstract Method.
           public void Add(int num1, int num2);

      But, remember if you want to make any method an abstract method, then you should explicitly use the abstract modifier as follows. 
      And once you use the abstract modifier, automatically the method is going to be called an abstract method.
          public abstract void Add(int num1, int num2);

   ** Abstract Classes in C#:
      A class under which we define abstract methods is known as an abstract class. 
      As per object-oriented programming, we need to define a method inside a class. 
      And, we cannot define the abstract methods directly anywhere, we need to define the abstract method inside an abstract class only.

   ** Abstract Class Cannot Be Instantiated in C#: Because it is not a fully implemented class as its abstract methods cannot be executed
      
    */
    /// <summary>

    internal class AbstractClass
    {
        public AbstractClass()
        {


        }

        public void AbstractChildMethod()
        {
            AbsChild absChild = new AbsChild();
            absChild.Add(10, 5);
            absChild.Sub(10, 5);
            absChild.Mul(10, 5);
            absChild.Div(10, 2);
            Console.ReadKey();
        }
        /// <summary>
        /// Here, the child class overrides the parent class members as well as we defined a pure child class method 
        /// i.e. Mod in the child class. As this method is purely defined in the child class, 
        /// we cannot call this method using the Parent class reference variable. Using the parent class reference variable, 
        /// we can call the parent class non-abstract methods, child class overridden methods but not the pure child class methods.
        /// </summary>
        public void AbstractParentMethod()
        {
            //Creating Child class instance
            AbsChild absChild = new AbsChild();
            //Creating abstract class reference pointing to child class object
            AbsParent absParent = absChild;
            //Accessing methods using reference
            absParent.Add(10, 5);
            absParent.Sub(10, 5);
            absParent.Mul(10, 5);
            absParent.Div(10, 2);
            //You cannot call the Mod method using Parent reference as it is a pure child class method
            //absParent.Mod(100, 35);
            Console.ReadKey();
        }
    }

}


public abstract class AbsParent
{
    public void Add(int x, int y)
    {
        Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
    }
    public void Sub(int x, int y)
    {
        Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
    }
    public abstract void Mul(int x, int y);
    public abstract void Div(int x, int y);
}
public class AbsChild : AbsParent
{
    public override void Mul(int x, int y)
    {
        Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
    }
    public override void Div(int x, int y)
    {
        Console.WriteLine($"Division of {x} and {y} is : {x / y}");
    }
}

//------------------------------------------------------

//https://dotnettutorials.net/lesson/abstract-class-abstract-methods-csharp/
