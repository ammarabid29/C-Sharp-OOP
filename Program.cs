namespace C_Sharp_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new()
            {
                name = "John",
                age = "20",
                marks = 90
            };
            student.detail();

        }
    }
    class Student
    {
        public required string name;
        public required string age;
        public int marks;

        public void detail()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Marks: {marks}");
        }
    }
}
