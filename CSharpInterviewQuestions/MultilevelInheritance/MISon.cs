using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewQuestions.MultilevelInheritance
{
   public class MISon:MIParent
    {

        /*
         
         Multilevel Inheritance :  When one class is derived from another derived class 
         then this type of inheritance is called multilevel inheritance.

         */

        public void SonAsserts()
        {
            Console.WriteLine("Son Asserts are : 25 Lac ");
        }
    }
}
