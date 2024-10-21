// B00882634 Clare Hamilton
using StudentLibrary;
class Program
{
    static void Main(string[] args)
    {
        //instance using default constructor
        Student student1 = new Student();

        //instance using custom constructor
        Student student2 = new Student();

        student1.Display();
        student2.Display();

        student1.GetOlder();
        student2.GetOlder();
         
        Console.WriteLine("Implementing Student Older");
        student1.Display();
        student2.Display();
    }

}
