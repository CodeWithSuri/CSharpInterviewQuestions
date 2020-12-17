using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewQuestions.MultipleInheritance
{
    public class LoanCalculator : CarLoan, HomeLoan, PersonalLoan
    {

        /*
         
            C# does not support's the multiple inheritances of classes, 
            to overcome this problem we can use the multiple interfaces 
            to achive the multiple inheritance concept in C#.
 
         */
        public int CalculateCarLoan(int loanAmount, int years)
        {
            int intresetRate = 9;


            return loanAmount * years * intresetRate / 100;

            

        }

        public int CalculateHomeLoan(int loanAmount, int years)
        {
            int intresetRate = 8;


            return loanAmount * years * intresetRate / 100;
        }

        public int CalculatePersonalLoan(int loanAmount, int years)
        {
            int intresetRate = 11;


            return loanAmount * years * intresetRate / 100;
        }
    }
}
