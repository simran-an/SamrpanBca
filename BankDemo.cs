using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamrpanBca
{
    class BankDemo
    {
        static void Main(string[] args)
        {
            //create object of persons class.
            Persons persons = new Persons();
            StringBuilder strBuilder = new StringBuilder();

            //inirialize a new var called personsData that can hold the data returned by GetAllPersons( )function
            var personsData = persons.GetAllPersons();

            Console.WriteLine("{0} records found", personsData.Count());
            strBuilder.AppendLine("\n\nDisplaying Persons Data using FOR-Each Loop");
            strBuilder.AppendLine("---------------------------------------");
            //Display All Persons returned and stored in personsData variable
            foreach (var displaypeople in personsData)
            {
                strBuilder.AppendLine
                    (
                    $"{displaypeople.Pid}\t" +
                    $"{displaypeople.Pname}\t" +
                    $"{displaypeople.Pprofession}\t" +
                    $"{displaypeople.Paddress}\t" +
                    $"{displaypeople.DOB.ToString("dddd, dd MMMM yyyy")}");
            }
            Console.WriteLine(strBuilder);

            //displaying all persons using for loop
            StringBuilder newString = new StringBuilder();
            newString.AppendLine("\n\nDisplaying Persons Data using FOR Loop");
            newString.AppendLine("---------------------------------------");
            //Display All Persons returned and stored in personsData variable
            for (int i = 0; i < personsData.Count(); i++)
            {
                newString.AppendLine(
                $"{personsData[i].Pid}\t" +
                $"{personsData[i].Pname}\t" +
                $"{personsData[i].Pprofession}\t" +
                $"{personsData[i].Paddress}\t" +
                $"{personsData[i].DOB.ToString("dddd, dd MMMM yyyy")}");
            }
            newString.AppendLine("S.No\tFull Name\tProfession\t\tAddress\t\tDate of Birth(DOB)");
            Console.WriteLine(newString);

        


            //Declaration of Varialable
            string AccountHolderName = "";
            int InitialBalance = 0;


            Console.WriteLine("Welcome to Himalayan Bank Ltd.\n");
            Console.WriteLine("---------------------------------------------");
            Console.Write("\n");

            Console.WriteLine("Enter Account Holder's Name:");
            AccountHolderName = Console.ReadLine().ToUpper().ToString();

            //Initial balance in Account
            Console.WriteLine("Enter Initial Balance deposited:");
            InitialBalance = Convert.ToInt32(Console.ReadLine());

            var account = new BankAccount(AccountHolderName, InitialBalance);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Fixed Deposit (Refundable on Account Close");
            Console.WriteLine("Fixed Deposit: " + account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Cash Back Offer (Rs. 100)");
            Console.WriteLine("Cash Back (from Bank): " + account.Balance);

            Console.WriteLine("==========================================================");

            Console.WriteLine(account.GetAccountHistory());

            // Test that the initial balances must be positive:
            try
            {
                var invalidAccount = new BankAccount("invalid", InitialBalance);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance", e.Message);
                Console.WriteLine(e.ToString());
            }

            // Test for a negative balance
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey(true);
        }
    }
}
