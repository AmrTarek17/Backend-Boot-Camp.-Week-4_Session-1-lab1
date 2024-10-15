using System;
using StudentLib; // Include the namespace from the Student class library

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Student object using the Student class from the library
            Student student = new Student(1, "Amr", 21, "Computer Science");

            // Display student details
            Console.WriteLine(student.GetStudentDetails());

            // Check eligibility to graduate
            bool eligible = student.IsEligibleToGraduate();
            Console.WriteLine($"Eligible to graduate: {eligible}");
        }
    }
}
