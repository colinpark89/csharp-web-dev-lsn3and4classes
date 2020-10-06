using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string Name;
        public string name
        {
            get { return Name; }
            internal set { Name = value; }
        }
        private int StudentId;
        public int studentId
        {
            get { return StudentId; }
            internal set { StudentId = value; }
        }
        private int NumberOfCredits;
        public int numberOfCredits
        {
            get { return NumberOfCredits; }
            internal set { NumberOfCredits = value; }
        }
        private double Gpa;
        public double gpa
        {
            get { return Gpa; }
            internal set { Gpa = value; }
        }
    }
}
