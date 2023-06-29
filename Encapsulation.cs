using System.ComponentModel.DataAnnotations;

namespace OOPConcepts
{
    /// <summary>
    /// Here the class Bank is an example of Encapsulation. The variables(AccountNumber, Name, and Balance) 
    /// and methods(GetBalance, WithdrawAmount, and Deposit) of the class are bound in a single unit which is the Bank class. 
    /// Here, the encapsulation binds the implementation details of the Bank class with it and hides it from other classes. 
    /// If other classes want to access these detail, 
    /// they need to create the object of the Bank class in order to access its data and behavior as shown in the below code.
    /// </summary>


    internal class Encapsulation
    {

        public Encapsulation()
        {

            Bank bank = new Bank();
            bank.AccountNumber = 12345678;
            bank.Name = "Pranata";
            bank.GetBalance();
            bank.WithdrawAmount();
        }
        public void BankHidingDataMethod()
        {
            try
            {
                BankHidingData bank = new BankHidingData();
                //You cannot access the Private Variable
                //bank.balance; //Compile Time Error
                //You can access the private variable via public setter and getter methods
                bank.SetBalance(500);
                Console.WriteLine(bank.GetBalance());//Output: 500

                //We cannot access the Amount Variable directly
                //bank.Amount = 50; //Compile Time Error
                //Console.WriteLine(bank.Amount); //Compile Time Error
                //Setting Positive Value
                bank.SetAmount(10);
                Console.WriteLine(bank.GetAmount());
                //Setting Negative Value
                bank.SetAmount(-150);
                /*
                 Output: 10
                        "Please Pass a Positive Value"
                 */
                Console.WriteLine(bank.GetAmount());


                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        //------------------------
        public void BankHidingDataByPropertiseMethod()
        {

            try
            {
                BankHidingDataByPropertise bank = new BankHidingDataByPropertise();
                //We cannot access the _Amount Variable directly
                //bank._Amount = 50; //Compile Time Error
                //Console.WriteLine(bank._Amount); //Compile Time Error
                //Setting Positive Value using public Amount Property
                bank.Amount = 10;
                //Setting the Value using public Amount Property
                Console.WriteLine(bank.Amount);

                //Setting Negative Value
                bank.Amount = -150;
                Console.WriteLine(bank.Amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }

}
//----------------------------------
class Bank
{

    public long AccountNumber;
    public string Name;
    public int Balance;
    public void GetBalance()
    {
    }
    public void WithdrawAmount()
    {
    }
    public void Deposit()
    {
    }
}
/// <summary>
/// Implementing Data Encapsulation or Data Hiding in C# using Setter and Getter Methods:
/// In the following example, we declare the balance variable as private in the Bank class, 
/// and hence it can not be accessed directly from outside of the Bank class. 
/// In order to access the balance variable from outside the Bank class, 
/// we have exposed two public methods i.e. GetBalance and SetBalance. 
/// The GetBalance method (which is also called getter) is used to fetch the value stored in the balance variable 
/// whereas the SetBalance method (which is also called Setter) is used to set the value in the balance variable from outside the bank class. Within the Bank class, 
/// you can access the private variables directly, but you cannot access them directly from outside of the Bank class.
/// </summary>
/*
If we are Providing Variable Access via Setter and Getter Methods in C#, 
then we can validate the user-given data before storing the value in the variable.
 */
class BankHidingData
{
    //Hiding class data by declaring the variable as private
    private double balance;
    //Creating public Setter and Getter methods
    //Public Getter Method
    //This method is used to return the data stored in the balance variable
    public double GetBalance()
    {
        //add validation logic if needed
        return balance;
    }
    //Public Setter Method
    //This method is used to stored the data  in the balance variable
    public void SetBalance(double balance)
    {
        // add validation logic to check whether data is correct or not
        this.balance = balance;
    }

    private int Amount;
    public int GetAmount()
    {
        return Amount;
    }
    public void SetAmount(int Amount)
    {
        if (Amount > 0)
        {
            this.Amount = Amount;
        }
        else
        {
            throw new Exception("Please Pass a Positive Value");
        }
    }
}
//----------------------
/// <summary>
/// Implementing Data Encapsulation or Data Hiding in C# using Properties:
/// n the below example, inside the Bank class, we marked the _Amount variable as private to restrict direct access from outside the Bank class. 
/// In order to access the _Amount variable, we have exposed the Amount property by declaring it as public. 
/// Now from outside the Bank class, we can access the _Amount private variable through the public exposed Amount property.
/// </summary>
public class BankHidingDataByPropertise
{
    private double _Amount;
    public double Amount
    {
        get
        {
            return _Amount;
        }
        set
        {
            // Validate the value before storing it in the _Amount variable
            if (value < 0)
            {
                throw new Exception("Please Pass a Positive Value");
            }
            else
            {
                _Amount = value;
            }
        }
    }
}

//https://dotnettutorials.net/lesson/encapsulation-csharp/