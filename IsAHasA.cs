namespace OOPConcepts
{
    /// <summary>
    /// If a class is inheriting from some other class, then it is having an ‘IS A’ relationship with that class 
    /// or if a class is having an object of some other class, then it is having a ‘HAS A’ relationship with that class. 
    /// So, Table has a Rectangle, and a Cuboid is a Rectangle.
    /// </summary>
    internal class IsAHasA
    {
        public IsAHasA() { }
       //Sample1:
        public void RecCubMethod()
        {
            Cuboid cuboid = new Cuboid(3, 5, 7);
            Console.WriteLine($"Volume is : {cuboid.Volume()}");
            Console.WriteLine($"Area is : {cuboid.Area()}");
            Console.WriteLine($"Perimeter is : {cuboid.Perimeter()}");
            Console.ReadKey();

        }

        class Rectangle
        {
            //Data Members
            public int Length;
            public int Breadth;
            //Member Functions
            public int Area()
            {
                return Length * Breadth;
            }
            public int Perimeter()
            {
                return 2 * (Length + Breadth);
            }
        }
        //Establishing Parent-Child Relationship
        //IS-A Relationship i.e. Cuboid IS-A Rectangle
        class Cuboid : Rectangle
        {
            public int Height;
            public Cuboid(int l, int b, int h)
            {
                Length = l;
                Breadth = b;
                Height = h;
            }
            public int Volume()
            {
                return Length * Breadth * Height;
            }
        }
        //------------------------------------------------------
        //Sample2:
        public void EmployeeAddressMethod()
        {
            Address address = new Address("B1-3029", "BBSR", "Odisha");
            Employee employee = new Employee(1001, "Ramesh", address);
            employee.Display();
            Console.ReadKey();
        }
        class Address
        {
            public string AddressLine, City, State;
            public Address(string addressLine, string city, string state)
            {
                AddressLine = addressLine;
                City = city;
                State = state;
            }
        }
        class Employee
        {
            //Using Address in Employee class
            //Establishing Has-A relationship i.e. Employee HAS-A Address   
            public Address address;
            public int Id;
            public string Name;
            public Employee(int id, string name, Address adrs)
            {
                Id = id;
                Name = name;
                address = adrs;
            }
            public void Display()
            {
                Console.WriteLine($"Employee Id: {Id}");
                Console.WriteLine($"Employee Name: {Name}");
                Console.WriteLine($"AddressLine: {address.AddressLine}");
                Console.WriteLine($"City: {address.City}");
                Console.WriteLine($"State: {address.State}");
            }
        }
    }
}
//https://dotnettutorials.net/lesson/isa-and-hasa-relationship-in-csharp/