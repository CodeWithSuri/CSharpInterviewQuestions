using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewQuestions.Encapsulation
{
   public class Bank
    {
        //we have declared bal variable as private 
        private double bal;
        public double Balance
        {
            get
            {
                return bal;
            }
            set
            {

                if (value < 0)
                {
                    Console.WriteLine("Please enter the positive amount !");
                }
                bal = value;
            }
        }
    }
}
