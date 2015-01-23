using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter your birthday in format(dd.mm.yyyy): ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime limit = DateTime.Parse("01.01.1900");
        if (birthday < limit)
        {
            Console.WriteLine("OMG..... You are dead!");
            Console.ReadLine();
            return;
        }
        DateTime now = DateTime.Now;
        TimeSpan age = now - birthday;
        if (birthday > now)
        {
            Console.WriteLine("Wait until you are born and try again!");
            Console.ReadLine();
            return;
        }
        int ageIndays = age.Days;
        int ageInyears = (ageIndays / 365);        
        Console.WriteLine("Your age is: " + ageInyears + " years.");
        Console.WriteLine("In 10 years you will be " + (ageInyears + 10) + " years old." );
        Console.ReadLine();
    }
}
