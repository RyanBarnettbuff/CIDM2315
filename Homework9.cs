namespace Homework9;

class Student{
        private int studentID;
        private string studentName;
        public static List<Student> studentList = new List<Student>();

        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            studentList.Add(this);
        }

        public string GetName()
        {
            return studentName;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {studentID}, Name: {studentName}");
        }
}

class Program{
    static void Main(string[] args)
    {
            new Student(111, "Alice");
            new Student(222, "Bob");
            new Student(333, "Cathy");
            new Student(444, "David");

            Dictionary<string, double> gradebook = new Dictionary<string, double>();
            gradebook.Add("Alice", 4.0);
            gradebook.Add("Bob", 3.6);
            gradebook.Add("Cathy", 2.5);
            gradebook.Add("David", 1.8);

            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook.Add("Tom", 3.3);
            }

            double totalGpa = 0;
            foreach (var entry in gradebook)
            {
                totalGpa += entry.Value;
            }
            double averageGpa = totalGpa / gradebook.Count;
            Console.WriteLine($"Average GPA: {averageGpa:F2}");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Students with GPA above average:");
            foreach (var student in Student.studentList)
            {
                if (gradebook.ContainsKey(student.GetName()))
                {
                    if (gradebook[student.GetName()] > averageGpa)
                    {
                        student.PrintInfo();
                        Console.WriteLine($"GPA: {gradebook[student.GetName()]}");
                    }
                }
            }
    }
}