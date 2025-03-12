namespace C_Sharp_OOP.com.StudentManagement
{
    // Encapsulation
    class Student
    {
        private string? name;
        private int age;
        private int marks;

        // Default Constructor
        public Student()
        {
            Console.WriteLine("Student Default Constructor Called");
            name = "Unknown";
            age = 1;
            marks = 0;
        }
        // Parameterized Constructor
        public Student(string n, int a, int m)
        {
            Console.WriteLine("Student Parameterized Constructor Called");
            name = n;
            age = a;
            marks = m;
        }

        // Setters
        public void SetName(string n)
        {
            if (!string.IsNullOrEmpty(n))
            {
                name = n;
            }
            else
            {
                Console.WriteLine("Name should not be empty");
            }
        }
        public void SetAge(int a)
        {
            if (a > 0)
            {
                age = a;
            }
            else
            {
                Console.WriteLine("Age should be greater than 0");
            }
        }
        public void SetMarks(int m)
        {
            if (m < 0)
            {
                Console.WriteLine("Marks should be greater than 0");
            }
            else
            {
                marks = m;
            }

        }

        public void Detail()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Marks: {marks}");
        }
        // method overloading -> same method name with different parameters
        public void Detail(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine($"Name: {name}, Age: {age}, Marks: {marks}");
        }

    }

    // Access Specifiers
    // public -> Accessible from anywhere
    // private -> Accessible only within the class  
    // protected -> Accessible within the class and derived class
    // internal -> Accessible within the Project / Solution
    // protected internal -> Accessible within the Project / Solution and derived class
    // private protected -> Accessible within the Project / Solution and derived class but not outside the Project / Solution

    // Value Type vs Reference Type
    // Stack Memory vs Heap Memory
    /*
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
    */
}