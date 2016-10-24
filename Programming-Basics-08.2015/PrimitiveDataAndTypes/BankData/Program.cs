using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccountData
{
    static void Main()
    {
        Console.Write("First Name:");
        string firstName = Console.ReadLine();
        Console.Write("Middle Name:");
        string middleName = Console.ReadLine();
        Console.Write("Last Name:");
        string lastName = Console.ReadLine();
        Console.Write("Amount of Money:");
        decimal amountOfMoney = decimal.Parse(Console.ReadLine());
        Console.Write("Bank Name:");
        string bankName = Console.ReadLine();
        Console.Write("IBAN:");
        string accountIBAN = Console.ReadLine();
        Console.Write("CreditCard Number:");
        long creditCardNum1 = long.Parse(Console.ReadLine());
        Console.Write("CreditCard Number:");
        long creditCardNum2 = long.Parse(Console.ReadLine());
        Console.Write("CreditCard Number:");
        long creditCardNum3 = long.Parse(Console.ReadLine());

        Console.WriteLine("*********************************************************************");
        Console.WriteLine("This Bank account belongs to {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("The amount of money in the account is {0} lv.", amountOfMoney);
        Console.WriteLine("The name of the bank is {0}", bankName);
        Console.WriteLine("The IBAN number is {0}", accountIBAN);
        Console.WriteLine("This holder credit card numbers are the first {0}, the second {1}, the third {2}", creditCardNum1, creditCardNum2, creditCardNum3);
    }
}



