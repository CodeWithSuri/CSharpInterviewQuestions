using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewQuestions.Polymorphism
{
   public class Calculator
    {


        public static int Add(int value1,int value2)
        {
            return value1 + value2;

        }


        public static double Add(int value1, double value2)
        {
            return value1 + value2;

        }

        public  double Add(double value1, double value2)
        {
            return value1 + value2;

        }

        


    }
}
