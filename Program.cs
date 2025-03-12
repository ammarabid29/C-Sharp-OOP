using C_Sharp_OOP.com.StudentManagement;

namespace C_Sharp_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation -> 
            Student student = new();
            student.SetName("Ammar");
            student.SetMarks(90);
            student.SetSemester(8);

            // full property
            student.SetSemester(2);
            Console.WriteLine($"Student Semester: {student.MySemester}");

            // auto property
            student.MyAge = 23;
            Console.WriteLine($"Student Age: {student.MyAge}");

            student.Detail();

            // Parameterized Constructor
            // Student student2 = new("Ammar", 23, 90, 2);
            // student2.Detail("Student2");
            // Console.WriteLine($"Student 2 Semester: {student2.Semester}");

            // Value Type vs Reference Type
            // Stack Memory vs Heap Memory
            /*
            Console.WriteLine("Struct -> Value Type -> Stack Memory");
            // variable store in stack which have value of object
            StudentStruct student1 = new() // value type -> stack
            {
                age = 20,
                marks = 90
            };
            student1.Detail();

            // stuct is value type so it will create new copy of student1
            // so student1 and student2 are independent of each other
            StudentStruct student2 = student1;
            student2.age = 25;
            student2.Detail();
            student1.Detail();

            Console.WriteLine("\nClass -> Reference Type -> Heap Memory");
            // variable store in stack which have reference adress of object in heap
            StudentClass student3 = new() // reference type -> heap
            {
                age = 20,
                marks = 90
            };
            student3.Detail();

            // both student3 and student4 are pointing to same object in heap
            // student4 value changes will reflect in student3
            StudentClass student4 = student3;
            student4.age = 25;
            student4.Detail();
            student3.Detail();
            */
        }
    }

}
