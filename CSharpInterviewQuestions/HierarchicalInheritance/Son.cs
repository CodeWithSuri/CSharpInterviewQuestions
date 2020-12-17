using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewQuestions.HierarchicalInheritance
{
   public class Son:Parent
    {

        /*
         
         Hierarchical Inheritance : 
        If one base class having the multiple derived classes then it is called Hierarchical Inheritance.
        
        Here son,daughter derived classes inherits the properties from a one base(parent) class. 
         
         */

        public void SonAsserts()
        {
            Console.WriteLine("Son Asserts are : 25 Lac ");
        }
    }
}
