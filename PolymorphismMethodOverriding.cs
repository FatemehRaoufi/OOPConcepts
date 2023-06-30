namespace OOPConcepts
{
    /// <summary>
    /// 
    /// What is Method Overriding in C#?
    ///The process of re-implementing the superclass non-static, non-private, and non-sealed method 
    ///in the subclass with the same signature is called Method Overriding in C#. 
    ///The same signature means the name and the parameters (type, number, and order of the parameters) should be the same. 
    /// </summary>
    internal class PolymorphismMethodOverriding
    {
        public PolymorphismMethodOverriding()
        {
            PolymorphismMethodOverridingClass1 obj1 = new PolymorphismMethodOverridingClass2();
            obj1.Show();
            PolymorphismMethodOverridingClass2 obj2 = new PolymorphismMethodOverridingClass2();
            obj2.Show();
            //------------------
            PolymorphismMethodOverridingClass3 obj3 = new PolymorphismMethodOverridingClass3();
            obj3.Show();
            PolymorphismMethodOverridingClass1 obj4 = new PolymorphismMethodOverridingClass3();
            obj4.Show();

            //-----------------------------------
            //Using the base keyword to call the Parent Class Methods
            PolymorphismMethodOverridingClass1 obj11 = new PolymorphismMethodOverridingClass4();
            obj11.Show();
            PolymorphismMethodOverridingClass4 obj12 = new PolymorphismMethodOverridingClass4();
            obj12.Show();
            //------------------------------
            PolymorphismMethodOverridingClass1 obj111 = new PolymorphismMethodOverridingClass5();
            obj111.Show();
            PolymorphismMethodOverridingClass5 obj112 = new PolymorphismMethodOverridingClass5();
            obj112.Show();
            Console.ReadKey();

            //----------------------------

        }


    }
    class PolymorphismMethodOverridingClass1
    {
        //Virtual Function (Overridable Method)

        public virtual void Show()
        {
            //Parent Class Logic Same for All Child Classes
            Console.WriteLine("Parent Class Show Method");
        }
    }
    class PolymorphismMethodOverridingClass2 : PolymorphismMethodOverridingClass1
    {
        //Overriding Method
        public override void Show()
        {
            //Child Class Reimplementing the Logic
            Console.WriteLine("Child Class Show Method");
        }
       
    }
    class PolymorphismMethodOverridingClass3 : PolymorphismMethodOverridingClass1
    {
        //Not Overriding the Virtual Method
    }
    class PolymorphismMethodOverridingClass4 : PolymorphismMethodOverridingClass1
    {
        public override void Show()
        {
            //Child Class Reimplementing the Logic
            base.Show(); //Using the base keyword to call the Parent Class Methods
            Console.WriteLine("Child Class Show Method");
        }
    }
    class PolymorphismMethodOverridingClass5 : PolymorphismMethodOverridingClass1
    {
        public override void Show()
        {
            //Creating an instance of Parent Class
            PolymorphismMethodOverridingClass1 class1 = new PolymorphismMethodOverridingClass1();
            //Calling Parent Class Show method
            class1.Show();
            Console.WriteLine("Child Class Show Method");
        }
    }
}
//https://dotnettutorials.net/lesson/function-overriding-csharp/