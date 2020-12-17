using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewQuestions.Polymorphism
{
   public class CentralPetrol
    {

        public virtual double GetLatestPetrolPrice(int litters)
        {
            return 55.5*litters;
        }
    }
}
