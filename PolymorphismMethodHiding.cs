namespace OOPConcepts
{
    internal class PolymorphismMethodHiding
    {
        /// <summary>
        ///In Method Overriding, the child classes re-implement their parent class methods which are declared as virtual. 
        ///That means here, the child classes re-implement the parent class methods with the permission of the parent class 
        ///because here in the parent class the method is declared as virtual giving permission to the child classes 
        ///for overriding the methods using the override modifier.
        ///
        /// In Method Hiding/Shadowing, the child classes can re-implement any method of its parent class methods even if they are not declared as virtual. 
        /// That means here the child class re-implements the parent class methods without taking any permission from its parent.
        
        /// <summary>
        public PolymorphismMethodHiding() 
        {
            Child obj = new Child();
            obj.Show();
            obj.Display();
            

            //-----------------------
            Child2 obj2 = new Child2();
            obj2.Show();
            obj2.Display();
            //-----------------------
            Console.ReadKey();
        }

    }
    public class Parent1
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class Show Method");
        }
        public void Display()
        {
            Console.WriteLine("Parent Class Display Method");
        }
    }
    public class Child1 : Parent1
    {

    }
    public class Child2 : Parent1
    {//Method Overriding
        public override void Show()
        {
            Console.WriteLine("Child Class Show Method");
        }
        //Method Hiding/Shadowing
        public new void Display()
        {
            Console.WriteLine("Child Class Display Method");
        }
    }
    //-----------------------------------------------------------
    public class Parent2
    {
        public virtual void Method1()
        {
            Console.WriteLine("Parent Class Method1 Method");
        }
        public void Method2()
        {
            Console.WriteLine("Parent Class Method2 Method");
        }
        public virtual void Method3()
        {
            Console.WriteLine("Parent Class Method3 Method");
        }
        public void Method4()
        {
            Console.WriteLine("Parent Class Method4 Method");
        }
    }
    public class Child12 : Parent2
    {
        //Overriding Virtual Method
        //Method Overriding
        public override void Method1()
        {
            Console.WriteLine("Child Class Method1 Method");
        }
        //Overriding Non-Virtual Method
        //Not Possible. Compile Time Error
        public override void Method2()
        {
            Console.WriteLine("Child Class Method2 Method");
        }

        //Method Hiding/Shadowing Virtual Method
        public new void Method3()
        {
            Console.WriteLine("Child Class Method3 Method");
        }
        //Method Hiding/Shadowing Non-Virtual Method
        public new void Method4()
        {
            Console.WriteLine("Child Class Method4 Method");
        }
    }


}
//https://dotnettutorials.net/lesson/function-hiding-csharp/