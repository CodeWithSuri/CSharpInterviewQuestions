using CSharpInterviewQuestions.Abstraction;
using CSharpInterviewQuestions.Encapsulation;
using CSharpInterviewQuestions.HierarchicalInheritance;
using CSharpInterviewQuestions.MultilevelInheritance;
using CSharpInterviewQuestions.MultipleInheritance;
using CSharpInterviewQuestions.Polymorphism;
using CSharpInterviewQuestions.SingleInheritance;
using System;

namespace CSharpInterviewQuestions
{
   public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("----------------------------------Encapsulation-----------------------");
            Bank suriBank = new Bank();
            suriBank.Balance = 1500;
            Console.WriteLine(suriBank.Balance);


            Console.WriteLine("----------------------------------Abstraction-----------------------");
            UPIAccount suriUpi = new UPIAccount();

            suriUpi.BankName = "Suri Bank";
            suriUpi.accountType = "Salary";
            suriUpi.UPIAccountNumber = "7382659190@Oksuri";
            suriUpi.accountHolderName = "Surendra Kumar L";
            suriUpi.Balance = 62000;
            suriUpi.AccountDetails();


            Console.WriteLine("----------------------------Single Inheritance-----------------------");
            Child child = new Child();
            child.ChildAsserts();
            child.ParentAsserts();

            Console.WriteLine("----------------------------Hierarchical Inheritance-----------------");


            Son son = new Son();

            son.ParentAsserts();
            son.SonAsserts();
            Console.WriteLine("------------------------");

           Daughter daughter = new Daughter();
            daughter.ParentAsserts();
            daughter.DaughterAsserts();


            Console.WriteLine("----------------------------Multilevel Inheritance-----------------");


            MISon mIson = new MISon();
            mIson.GrandParentAsserts();
            mIson.ParentAsserts();
            mIson.SonAsserts();
            Console.WriteLine("------------------------");

            MIDaughter mIdaughter = new MIDaughter();
            mIdaughter.GrandParentAsserts();
            mIdaughter.ParentAsserts();
            mIdaughter.DaughterAsserts();



            Console.WriteLine("----------------------------Multiple Inheritance-----------------");


            LoanCalculator loanCalculator = new LoanCalculator();
            
           Console.WriteLine("5 Lac Personal loan interest for 5Years :" + loanCalculator.CalculatePersonalLoan(500000,5));
            Console.WriteLine("5 Lac Car loan interest for 5Years:" + loanCalculator.CalculateCarLoan(500000, 5));
            Console.WriteLine("5 Lac Home loan interest for 5Years :" + loanCalculator.CalculateHomeLoan(500000, 5));




            Console.WriteLine("--------------------------Compile Time Polymorphism---------------");


            Calculator calculatior = new Calculator();

            Console.WriteLine("With two int param value :"+calculatior.Add(1, 1));
            Console.WriteLine("With one int,one double param's value :" + calculatior.Add(1, 1.1));
            Console.WriteLine("With two double param value :" + calculatior.Add(1.5,1.8));

            Console.WriteLine("--------------------------Run Time Polymorphism---------------");

            CentralPetrol centralPetrol = new CentralPetrol();

            CentralPetrol apPetrol = new ApPetrol();

            CentralPetrol tsPetrol = new TSPetrol();
            CentralPetrol ksPetrol = new KSPetrol();




            Console.WriteLine(" CentralPetrol price per litter :" + centralPetrol.GetLatestPetrolPrice(1));

            Console.WriteLine("Andhra pradesh state Petrol price per litter :" + apPetrol.GetLatestPetrolPrice(1));


            Console.WriteLine("Tamilanadu state Petrol price per litter :" + tsPetrol.GetLatestPetrolPrice(1));
            Console.WriteLine("Karnataka state Petrol price per litter :" + ksPetrol.GetLatestPetrolPrice(1));



            /*
            The compiler requires an GetLatestPetrolPrice() method in CentralPetrol class 
            and it will find the method then compiles successfully.
            but the right version of the GetLatestPetrolPrice() method is not being determined at compile time
            but determined at runtime. Finally the overriding methods must have the same name and parameters/arguments,
            as the virtual or abstract method defined in the base class method and that it is overriding in the derived class.
             */

            Console.ReadLine();

        }
    }
}
