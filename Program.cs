namespace C_Sharp_OOP
{
    // struct is value type and store in stack memory
    // struct is used for small data structure
    struct StudentStruct
    {
        public int age;
        public int marks;

        public readonly void Detail()
        {
            Console.WriteLine($"Age: {age}, Marks: {marks}");
        }
    }

    // class is reference type and store in heap memory
    // class is used for large data structure
    class StudentClass
    {
        public int age;
        public int marks;

        public void Detail()
        {
            Console.WriteLine($"Age: {age}, Marks: {marks}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stuct -> Value Type -> Stack Memory");
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

        }
    }

}
