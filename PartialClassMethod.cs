namespace OOPConcepts
{

    internal class PartialClassMethod
    {
        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public double Salary { get; set; }

            public void DisplayFullName()
            {
                Console.WriteLine($"Full Name is : {FirstName} {LastName}");
            }
            public void DisplayEmployeeDetails()
            {
                Console.WriteLine("Employee Details : ");
                Console.WriteLine($"First Name : {FirstName}");
                Console.WriteLine($"Last Name : {LastName}");
                Console.WriteLine($"Gender : {Gender}");
                Console.WriteLine($"Salary : {Salary}");
            }
        }
        public PartialClassMethod()
        {

            Employee emp = new Employee
            {
                FirstName = "Pranaya",
                LastName = "Rout",
                Salary = 100000,
                Gender = "Male"
            };
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            //-------------------

            PartialEmployee partialEmp = new PartialEmployee()
            {

                FirstName = "Pranaya",
                LastName = "Rout",
                Salary = 100000,
                Gender = "Male"
            };
            partialEmp.DisplayFullName();
            partialEmp.DisplayEmployeeDetails();
           

            //--------------------------

            PartialClass1 SC = new PartialClass1();
            SC.PublicMethod();
            Console.ReadKey();
        }

        //Splitting Above Class Definition into 2 Files using Partial Classes in C#:
        /*
         we will split the above Employee class definition into two different class files. 
        One class file is going to contain all 4 public auto-implemented properties (FirstName, LastName, Gender, and Salary), 
        and the other class file is going to contain the two public methods 
        i.e. DisplayFullName and DisplayEmployeeDetails that we have defined inside the Employee class.
         */
        //Adding PartialEmployeeOne.cs:
        public partial class PartialEmployee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public double Salary { get; set; }
        }
        //Adding PartialEmployeeTwo.cs:
        public partial class PartialEmployee
        {
            public void DisplayFullName()
            {
                Console.WriteLine($"Full Name is : {FirstName} {LastName}");
            }
            public void DisplayEmployeeDetails()
            {
                Console.WriteLine("Employee Details : ");
                Console.WriteLine($"First Name : {FirstName}");
                Console.WriteLine($"Last Name : {LastName}");
                Console.WriteLine($"Gender : {Gender}");
                Console.WriteLine($"Salary : {Salary}");
            }
        }
        //--------------------------------------------------------------------------
        //we can implement multiple inheritances in C# with interfaces.

        public interface IEmployee
        {
            void EmployeeMethod();
        }
        public interface ICustomer
        {
            void CustomerMethod();
        }
        public partial class PartialEmpClass : IEmployee
        {
            public void EmployeeMethod()
            {
                //Method Implementation
            }
        }
        public partial class PartialCustClass : ICustomer
        {
            public void CustomerMethod()
            {
                //Method Implementation
            }
        }
        //----------------------------------------------------------------

        //Partial Methods in C#:

        /*
         One part of the class contains the signature of the method. 
        An implementation of the Partial Method can be defined in the same part or other parts of the Partial Class. 
        If the implementation is not supplied, then the method 
        and all calls to the partial method are removed by the compiler at the time of compilation.
         */
        partial class PartialClass1
        {
            // Declaration of the partial method.
            partial void PartialMethod();

            // A public method calling the partial method
            public void PublicMethod()
            {
                Console.WriteLine("Public Method Invoked");
                PartialMethod();
            }
            // Partial method implemented
            partial void PartialMethod()
            {
                Console.WriteLine("Partial PartialMethod  Invoked");
            }
        }
    }

}
//https://dotnettutorials.net/lesson/partial-classes-partial-methods-csharp/