namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //Code for Q1

        string a = "a";
        string b = "b";
        string c = "c";
        string d = "d";
        string f = "f";

        Console.WriteLine("Please input a letter grade: ");
        string grade = Console.ReadLine().ToLower();

        if(grade==a){
            Console.WriteLine("GPA point: 4");
        }
        else if(grade==b){
            Console.WriteLine("GPA point: 3");
    }
        else if(grade==c){
            Console.WriteLine("GPA point: 2");
        }
        else if(grade==d){
            Console.WriteLine("GPA point: 1");
        }
        else if(grade==f){
            Console.WriteLine("GPA point: 0");
        }
        else{
            Console.WriteLine("Please enter valid letter grade.");
        }
        
        //Code for Q2
        
        Console.WriteLine("Please enter the first number: ");
        short number1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");
        short number2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please enter the last number: ");
        short number3 = Convert.ToInt16(Console.ReadLine());

        short smallest = number1;

        if(number2 < smallest){
            smallest=number2;
        }


        if (number3 < smallest){
            smallest=number3;
        }

        Console.WriteLine("The smallest value is:" + smallest );
    }
}
