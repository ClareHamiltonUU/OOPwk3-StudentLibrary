// B00882634 Clare Hamilton

namespace StudentLibrary
{
    internal class Student
    {
        //private fields
        private int id;
        private string name;
        private int age;
        private static int studentCount = 0;

        //public properties
        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age {
            get { return age; }
            set { age = value; }
        }

        //public static property - read only
        public static int StudentCount
        {
            get { return studentCount; }
        }


        //default constructor
        public Student()
        {
            name = "John Doe";
            age = 16;
            id = studentCount++;
        }

        //custom constructor
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            id = studentCount++;
        }

        //Display Method
        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}");
        }

        //GetOlder Method
        public int GetOlder()
        {
            return age++;
        }
    }
}
