﻿using C_Sharp_OOP.com.Composition;
using C_Sharp_OOP.com.PurePolymorphism;

namespace C_Sharp_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Composition
            /*
             */
            // Composition is "Has A" relationship
            // Both departments have life cycle depends on university object
            University university = new();
            university.AddDep("Arts", "Ali", AllDepartments.arts, 100);
            university.AddDep("Comp", "Ahmed", AllDepartments.comp, 10);

            foreach (var item in university.Departments)
            {
                Console.WriteLine($"Department Name: {item.Name}, Director: {item.Director}");
                if (item is ArtsDepartment)
                {
                    Console.WriteLine($"Number of Students: {((ArtsDepartment)item).NumberOfStudents}");
                }
                else if (item is CompDepartment)
                {
                    Console.WriteLine($"Number of Computer Labs: {((CompDepartment)item).NumberOfComputerLabs}");
                }
            }


            // Polymorphism
            /*
            
            // abstract class 
            Transformer transformer = new Car();         
            // this object only have access to methods of transformer class
            transformer.Run();
            transformer.Show();
            
            // Use interface for pure polymorphism
            // interface class
            ITransformer transformer = new Car();
            transformer.Run();
          
            IExample transformer2 = new Car();
            transformer2.Run();
             */

            // Inheritance
            /*
            Hardware hardware = new("CPU",1)
            {
                Price = 1000,
                Size = 10, 
            };
            hardware.Details();
            // if we have show method in hardware then it call that method
            // otherwise it call show method of parent class - > product
            hardware.Show();
            */

            // Encapsulation 
            /*
            // Parameterized Constructor
            Student student2 = new("Ammar", 23, 90, 2);
            // student2.Detail("Student2");
            // Console.WriteLine($"Student 2 Semester: {student2.Semester}");

            // Default Constructor
            Student student = new();
            student.SetName("Ammar");
            student.SetMarks(90);

            // auto property -> can't be set from outside of class
            // set through other function
            student.SetSemester(2);
            // Console.WriteLine($"Student Semester: {student.Semester}");

            // full property -> can be set from outside of class
            student.MyAge = 23;
            // Console.WriteLine($"Student Age: {student.MyAge}");

            // student.Detail();

            // indexer 
            student[200] = -10;
            */


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
