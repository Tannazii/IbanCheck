using System.ComponentModel.DataAnnotations;

namespace IbanCheck
{
     class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            do
            {
                Iban ibanAp = new Iban();

                Console.WriteLine("Enter Iban(with IR) :");
                ibanAp.IbanNumber = Console.ReadLine();



                IbanValidator validatorService = new IbanValidator();

                bool isvalid = validatorService.Validate(ibanAp);
                Console.WriteLine($"Iban is {isvalid}");

                IbanValidator accountService = new IbanValidator();
                decimal account = accountService.BBAN(ibanAp.IbanNumber);
                Console.WriteLine($"account : {account}");



                BankIdentify binService = new BankIdentify();
                string bankName = binService.DetectBin(ibanAp.IbanNumber);
                Console.WriteLine($"bankName :{bankName}");








            }
            while(isValid == false);



















        }
    }
}
