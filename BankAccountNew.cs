using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamrpanBca
{
    public class BankAccountNew
    {
        public string GenerateAccountHolderNumber()
        {
            Random rand = new Random();
            //int AccountNo = rand.Next(1500, 1800);
            //string AccountNumber = "nibl" + AccountNo.ToString();
            string AccountNumber = " NIBL- " + rand.Next(1500, 1800);
            return AccountNumber;

        }
        public int RecordInitialTransaction(string AccountNo, decimal InitialBalance)
    }
}
