namespace Homework7
{
    public class Customer
    {
        private int cus_id;
        public string cus_name;
        public int cus_age;

//Q1 and Q2 Answers
        public Customer(int cus_id, string cus_name, int cus_age)
        {
            this.cus_id = cus_id;
            this.cus_name = cus_name;
            this.cus_age = cus_age;
        }

        public void ChangeID(int new_id)
        {
            this.cus_id = new_id;
        }

        public void PrintCusInfo()
        {
            Console.WriteLine($"ID: {this.cus_id}, Name: {this.cus_name}, Age: {this.cus_age}");
        }

        public void CompareAge(Customer objCustomer)
        {
            if (this.cus_age > objCustomer.cus_age)
            {
                Console.WriteLine($"{this.cus_name} is older.");
            }
            else if (objCustomer.cus_age > this.cus_age)
            {
                Console.WriteLine($"{objCustomer.cus_name} is older.");
            }
            else
            {
                Console.WriteLine("Both are the same age.");
            }
        }
    }

//Customer Class
    class Program
    {
        static void Main(string[] args)
        {
            Customer cus1 = new Customer(110, "Alice", 28);
            Customer cus2 = new Customer(111, "Bob", 30);

            cus1.PrintCusInfo();
            cus2.PrintCusInfo();

            cus1.ChangeID(220);
            cus2.ChangeID(221);

            cus1.PrintCusInfo();
            cus2.PrintCusInfo();

            cus1.CompareAge(cus2);
        }
    }
}