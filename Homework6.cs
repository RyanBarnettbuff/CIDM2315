namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        // Q1
        Professor prof1 = new Professor();
        prof1.profName = "Alice";
        prof1.classTeach = "Java";
        prof1.SetSalary(9000);

        Professor prof2 = new Professor();
        prof2.profName = "Bob";
        prof2.classTeach = "Math";
        prof2.SetSalary(8000);

        Student student1 = new Student();
        student1.studentName = "Lisa";
        student1.classEnroll = "Java";
        student1.SetGrade(90);

        Student student2 = new Student();
        student2.studentName = "Tom";
        student2.classEnroll = "Math";
        student2.SetGrade(80);

        // Q2
        Console.WriteLine($"Professor: {prof1.profName}, teaches {prof1.classTeach}, and the salary is: {prof1.GetSalary()}");
        Console.WriteLine($"Professor: {prof2.profName}, teaches {prof2.classTeach}, and the salary is: {prof2.GetSalary()}");

        Console.WriteLine($"Student: {student1.studentName} is enrolled in {student1.classEnroll}, and thier grade is: {student1.GetGrade()}");
        Console.WriteLine($"Student: {student2.studentName} is enrolled in {student2.classEnroll}, and thier grade is: {student2.GetGrade()}");

        double salaryDiff = prof1.GetSalary() - prof2.GetSalary();
        Console.WriteLine($"The salary difference between {prof1.profName} and {prof2.profName} is: {salaryDiff}");

        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine($"The total grade of {student1.studentName} and {student2.studentName} is: {totalGrade}");
    }
}

class Professor
{
    public string profName;
    public string classTeach;
    private double salary;

    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }
}

class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}