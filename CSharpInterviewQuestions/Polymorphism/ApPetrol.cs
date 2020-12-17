using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewQuestions.Polymorphism
{
    public class ApPetrol :CentralPetrol
    {
        private double StateTax { get; set; }
        private double cpCost { get; set; }

        private double VAT { get; set; }

        public ApPetrol()
        {

            CentralPetrol cp = new CentralPetrol();
            cpCost = cp.GetLatestPetrolPrice(1);
            StateTax = 24.15;
            VAT = 19;


        }

        public override double GetLatestPetrolPrice(int litters)
        {
            return StateTax + VAT+(cpCost *litters);
        }

    }
}
