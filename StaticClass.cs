using static OOPConcepts.StaticClass.CountryMaster;

namespace OOPConcepts
{
    /// <summary>
    /// The class which is created by using the static modifier is called a static class in C#. 
    /// A static class can contain only static members. 
    /// It is not possible to create an instance of a static class. 
    ///  we can access the static members of a class by using the class name. 
    /// </summary>
    internal class StaticClass
    {
        public StaticClass() { }

        /// <summary>
        /// 
        /// </summary>
        public class CountryMaster
        {
            public string CountryCode { get; set; }
            public string CountryName { get; set; }

            private string ComputerName
            {
                get
                {
                    //CommonTask commonTask = new CommonTask();
                    return CommonTask.GetComputerName();
                }
            }
            public void Insert()
            {
                //CommonTask commonTask = new CommonTask();
                if (!CommonTask.IsEmpty(CountryCode) && !CommonTask.IsEmpty(CountryName))
                {
                    //Insert the data
                }
            }



            //-------------------------------------
            public class Customer
            {

                /* 
                 private bool IsEmpty(string value)
                 {
                     if (value.Length > 0)
                     {
                         return true;
                     }
                     return false;
                 }
                 public void Insert()
                 {
                     if (IsEmpty(CustomerCode) && IsEmpty(CustomerName))
                     {
                         //Insert the data
                     }
                 }


                 */
                public string CustomerCode { get; set; }
                public string CustomerName { get; set; }
                private string MachineName = "";
                public Customer()
                {
                    //CommonTask commonTask = new CommonTask();
                    //MachineName = commonTask.GetComputerName();
                    MachineName = CommonTask.GetComputerName();
                }
                public void Insert()
                {
                    //CommonTask commonTask = new CommonTask();
                    //if (!commonTask.IsEmpty(CustomerCode) && !commonTask.IsEmpty(CustomerName))
                    //{
                    //    //Insert the data
                    //}
                    if (!CommonTask.IsEmpty(CustomerCode) && !CommonTask.IsEmpty(CustomerName))
                    {
                        //Insert the data
                    }
                }
            }
            //--------------------------------
            public static class CommonTask
            {
                public static bool IsEmpty(string value)
                {
                    if (value.Length > 0)
                    {
                        return true;
                    }
                    return false;
                }
                public static string GetComputerName()
                {
                    return System.Environment.MachineName;
                }
            }
            //----------------------------

        }
    }
}

//https://dotnettutorials.net/lesson/static-class-in-csharp/