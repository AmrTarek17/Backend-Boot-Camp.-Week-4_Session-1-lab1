namespace StudentLib
{
    public class Student
    {
        // Fields or properties of the Student class
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }

        // Constructor
        public Student(int id, string name, int age, string major)
        {
            ID = id;
            Name = name;
            Age = age;
            Major = major;
        }

        // Function to display student details
        public string GetStudentDetails()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Major: {Major}";
        }

        // Function to check if the student is eligible to graduate (for example)
        public bool IsEligibleToGraduate()
        {
            return Age >= 22;
        }
    }
}


