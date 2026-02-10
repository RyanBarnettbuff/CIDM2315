using System.ComponentModel.DataAnnotations.Schema;

namespace Homework3;


class Program
{
    static void Main(string[] args)
    {
        //Q1 
        
        Console.WriteLine("Please input a number: ");
        int N = int.Parse(Console.ReadLine());

        if (N < 2)
        {
            Console.WriteLine($"{N} is not prime!");
        }

        bool primeCheck=true;
        int number=2;

        while (number < N)
        {
            if (N % number == 0)
            {
                primeCheck=false;
                break;
            }

            number++;

        }

        if (primeCheck)
        {
            Console.WriteLine($"{N} is prime!");
        }

        else
        {
            Console.WriteLine($"{N} is not prime!");
        }


        //Q2

        
        Console.WriteLine("Please input a number: ");
        int N = int.Parse(Console.ReadLine());

        for(int row=1; row<=N; row++)
        {
            for(int column=1; column<=(N-1); column++)
            {
                Console.Write("#");
            }
            Console.WriteLine("#");

        }


        //Q3

        Console.WriteLine("Please input a number: ");
        int N = int.Parse(Console.ReadLine());

        for(int row=1; row<=N; row++)
        {
            for(int column=1; column<row; column++)
            {
                Console.Write("#");
            }
            Console.WriteLine("#");

        }






    }
}
