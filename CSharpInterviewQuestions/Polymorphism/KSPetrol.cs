using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewQuestions.Polymorphism
{
    public class KSPetrol : CentralPetrol
    {
        private double StateTax { get; set; }
        private double cpCost { get; set; }

        private double VAT { get; set; }

        public KSPetrol()
        {

            CentralPetrol cp = new CentralPetrol();
            cpCost = cp.GetLatestPetrolPrice(1);
            StateTax = 14.15;
            VAT = 15;


        }

        public override double GetLatestPetrolPrice(int litters)
        {
            return StateTax + VAT + (cpCost * litters);
        }

    }
}
