
//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company 
//and its manager and prints it back on the console.

using System;
class Program
{
    static void Main()
    {
        Console.Write("Please enter a Name of the Company :");
        string a = Console.ReadLine();
        Console.Write("Please enter an adress :");
        string b = Console.ReadLine();
        Console.Write("Please enter a Phone Number :");
        string c = Console.ReadLine();
        Console.Write("Please enter a Fax Number :");
        string d = Console.ReadLine();
        Console.Write("Please enter a web site :");
        string e = Console.ReadLine();
        Console.Write("Please enter Manager First Name :");
        string f = Console.ReadLine();
        Console.Write("Please enter Last Name :");
        string g = Console.ReadLine();
        Console.Write("Please enter Age :");
        string h = Console.ReadLine();
        Console.Write("Please enter a Phone Number :");
        string k = Console.ReadLine();

        Console.WriteLine();

        string answer;

        Console.Write("Do you want to see the information (yes/no):");
        answer = Console.ReadLine();
        if (answer.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The company Information");
            Console.WriteLine("Name of the Company :{0}", a);
            Console.WriteLine("Adress: {0}", b);
            Console.WriteLine("Phone Number :{0}", c);
            Console.WriteLine("Fax Number :{0}", d);
            Console.WriteLine("Web Site:{0}", e);

            Console.WriteLine();

            Console.WriteLine("Manager Information");
            Console.WriteLine("Manager of the Company is:{0} {1}", f, g);
            Console.WriteLine("Age: {0}", h);
            Console.WriteLine("Phone Number {0}", k);
            Console.WriteLine();
            Console.WriteLine();

        }


        else if (answer.Equals("no", StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine("Thank you for your time;");
        }



    }

}
