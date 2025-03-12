namespace C_Sharp_OOP.com.StudentManagement
{
    // Encapsulation
    class Student
    {
        private string? name;
        private int marks;
        // property
        public int Semester { get; private set; }
        // full property
        private int age;
        public int MyAge
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age should be greater than 0");
                }
                else
                {
                    age = value;
                }
            }
        }
        // indexer
        private readonly int[] array = [1, 2, 3, 4, 5];
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    Console.WriteLine("Index out of range");
                }
                return 0;
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    if (value > 0)
                    {
                        array[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Value should be greater than 0");
                    }
                }
                else
                {
                    Console.WriteLine("Index out of range");
                }
            }
        }

        // Default Constructor
        public Student()
        {
            Console.WriteLine("Student Default Constructor Called");
            name = "Unknown";
            age = 1;
            marks = 0;
            Semester = 1;
        }
        // Parameterized Constructor
        public Student(string n, int a, int m, int s)
        {
            Console.WriteLine("Student Parameterized Constructor Called");
            name = n;
            age = a;
            marks = m;
            Semester = s;
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
        public void SetSemester(int s)
        {
            if (s < 0)
            {
                Console.WriteLine("Semester should be greater than 0");
            }
            else
            {
                Semester = s;
            }
        }

        public void Detail()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Marks: {marks}, Semester: {Semester}");
        }
        // method overloading -> same method name with different parameters
        public void Detail(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine($"Name: {name}, Age: {age}, Marks: {marks}, Semester: {Semester}");
        }

    }

    /*
    Access Specifiers
    public -> Accessible from anywhere
    private -> Accessible only within the class  
    protected -> Accessible within the class and derived class
    internal -> Accessible within the Project / Solution
    protected internal -> Accessible within the Project / Solution and derived class
    private protected -> Accessible within the Project / Solution and derived class but not outside the Project / Solution
    */

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
    */

    /*
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