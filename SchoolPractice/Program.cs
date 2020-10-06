using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student colin = new Student();
            colin.name = "Colin";
            colin.numberOfCredits = 1;
            colin.gpa = 4.0;

            Console.WriteLine(colin.name);

        }
    }
}
