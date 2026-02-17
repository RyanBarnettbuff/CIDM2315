using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Please input a number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Input a second number: ");
        int b = int.Parse(Console.ReadLine());

        int result=Largest(a,b);
        Console.WriteLine($"{result} is the largest number.");

        
        //Q2


        Console.WriteLine("Please input a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Left or Right? ");
        string shape = Console.ReadLine().ToLower();


        Console.WriteLine($"Number is {num}; Shape is {shape}");
        Pyramid(num,shape);
    }

//Q1
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
    static void Pyramid(int num, string shape)
    {
        if (shape == "left")
        {
            for(int row=1; row<=num; row++)
            {
                for(int column=1; column<row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
        else
        {
                for (int row = 1; row <= num; row++)
            {
                for (int space = 1; space <= num - row; space++)
                {
                    Console.Write(" ");
                }

                for (int column = 1; column <= row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
        }
        }



    }




}

