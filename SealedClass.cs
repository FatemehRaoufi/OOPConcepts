using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPConcepts
{
    /// <summary>
    /// A class from which it is not possible to create/derive a new class is known as a sealed class. 
    /// In simple words, we can say that when we define the class using the sealed modifier, 
    /// then it is known as a sealed class and a sealed class cannot be inherited by any other classes.
    /// 
    /// </summary>
    internal class SealedClass
    {

        public SealedClass()
        {
            Manager m1 = new Manager();
            m1.GetEmployeeDataSealedClass();
            m1.DisplayEmployeeDataSealedClass();
            Console.ReadKey();
        }



        public class EmployeeSealedClass
        {
            protected int Eid, Eage;
            protected string Ename, Eaddress;
            public virtual void GetEmployeeDataSealedClass()
            {
                Console.WriteLine("Enter Emplpyee Details:");
                Console.Write("Enter Employee ID:");
                Eid = int.Parse(Console.ReadLine());
                Console.Write("Enter Employee Name:");
                Ename = Console.ReadLine();
                Console.Write("Enter Employee Address:");
                Eaddress = Console.ReadLine();
                Console.Write("Enter Employee Age:");
                Eage = int.Parse(Console.ReadLine());
            }
            public virtual void DisplayEmployeeDataSealedClass()
            {
                Console.WriteLine("\nEmplpyee Details Are:");
                Console.WriteLine($"Employee ID: {Eid}");
                Console.WriteLine($"Employee Name: {Ename}");
                Console.WriteLine($"Employee Address: {Eaddress}");
                Console.WriteLine($"Employee Age: {Eage}");
            }
        }
        public sealed class Manager : EmployeeSealedClass
        {
            double Bonus, Salary;
            public override void GetEmployeeDataSealedClass()
            {
                Console.WriteLine("Enter Manager Details:");
                Console.Write("Enter Manager ID:");
                Eid = int.Parse(Console.ReadLine());
                Console.Write("Enter Manager Name:");
                Ename = Console.ReadLine();
                Console.Write("Enter Manager Salary:");
                Salary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Manager Bonus:");
                Bonus = double.Parse(Console.ReadLine());
            }
            public override void DisplayEmployeeDataSealedClass()
            {
                Console.WriteLine("\nManager Details Are:");
                Console.WriteLine($"Manager ID: {Eid}");
                Console.WriteLine($"Manager Name: {Ename}");
                Console.WriteLine($"Manager Salary: {Salary}");
                Console.WriteLine($"Manager Bonus: {Bonus}");
            }
        }
        //Further No Inheritance is Possible as we marked the class as sealed
        //public class TempManager : Manager
        //{
        //}
        /*
         hile creating the TempManager class from the Manager class, 
        we will get compile time error saying that ‘TempManager’: cannot derive from sealed type ‘Manager’.
         */

    }
    
}

//https://dotnettutorials.net/lesson/sealed-class-methods-csharp/
