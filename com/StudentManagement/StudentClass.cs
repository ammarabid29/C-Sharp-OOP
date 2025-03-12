namespace C_Sharp_OOP.com.StudentManagement
{
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
}