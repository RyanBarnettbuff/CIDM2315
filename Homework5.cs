using System.Diagnostics;
using System.IO.Pipelines;

namespace Homework5;

class Program
{
    static void Main(string[] args)
    {

        
        //Q1
        LargestLines();

        //Q2
        LargestFourLines();
 

        //Q3
        CreateAccount();
    }
    

    //Q1

    static void LargestLines()
    {
        Console.WriteLine("Please input a number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Input a second number: ");
        int b = int.Parse(Console.ReadLine());

        int result=largest(a,b);
        Console.WriteLine($"The largest number is: {result}.");
    }
    static int Largest (int a ,int b)
    {
        if (a < b)
        {
            return b;
        }

        else
        {
            return a;
        }
    }

    //Q2

    static void LargestFourLines()
    {
        Console.WriteLine("Please input a number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Input a second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input a third number: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Input a fourth number: ");
        int d = int.Parse(Console.ReadLine());

        int result=LargestFour(a,b,c,d);
        Console.WriteLine($"The largest number is: {result}.");
    }
    static int LargestFour (int a ,int b, int c, int d)
    {
        int largest=a;

        if (largest < b)
        {
            largest = b;
        }

        if(largest < c)
        {
            largest = c;
        }

        if(largest < d)
        {
            largest = d;
        }

        return largest;

    }

    //Q3
    static bool AgeCheck(int birthyear)
    {
        int currentyear = DateTime.Now.Year;
        int age = currentyear - birthyear;
        return age >= 18;
    }

    static void CreateAccount()
    {
        Console.WriteLine("Enter Username: ");
        string un = Console.ReadLine();
        Console.WriteLine("Enter Password: ");
        string password = Console.ReadLine();
        Console.WriteLine("Confirm Password: ");
        string password2 = Console.ReadLine();
        Console.WriteLine("Enter Birth Year: ");
        if (int.TryParse(Console.ReadLine(), out int dob))
        {
            if (AgeCheck(dob))
        {
            if (password == password2)
            {
                Console.WriteLine($"Account has been created! Welcome {un}");
            }

            else
            {
                Console.WriteLine("Wrong Password.");
            } 
        }

        else
        {
            Console.WriteLine("Cannot create account.");
        }
        }

        else
        {
             Console.WriteLine("Invalid Birth Year.");
        }

    }

}
