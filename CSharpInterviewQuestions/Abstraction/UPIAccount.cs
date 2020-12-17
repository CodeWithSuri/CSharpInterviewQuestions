using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewQuestions.Abstraction
{
   public class UPIAccount
    {
        private string bankName;

        public string accountType;
        private string upiaccountNumber;

        public string accountHolderName;

        private double accountBal;


        public string BankName
        {
            get { return bankName; }

            set { bankName = value; }
        }


        public double Balance
        {

            set { accountBal = value; }
        }

        public string UPIAccountNumber
        {
            get { return upiaccountNumber; }

            set { upiaccountNumber = value; }
        }


        public void AccountDetails()

        {
            Console.WriteLine("Bank Name: " + bankName);
            Console.WriteLine("Account Type: " + accountType);
            Console.WriteLine("Account Number: " + upiaccountNumber);
            Console.WriteLine("Account HolderName: " + accountHolderName);

        }

        private void GetAccountBalInfo()
        {
            Console.WriteLine("Account Balance Information :" + accountBal);

        }


        private void GetIntrestOnBal()
        {

            /* Here is the internal logic and we no need to expose the logic to client*/
            Console.WriteLine("Intreast on Bal:" + accountBal);

        }
    }
}
