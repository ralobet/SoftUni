using System;
class PrintMyName
{
    static void Main()
    {
        Console.Write("Print your name:");
        string name = Console.ReadLine();
        Console.WriteLine("***************************");
        Console.WriteLine("My name is {0}.", name);
    }
}

