using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP.com.Composition
{
    public enum AllDepartments
    {comp, arts }

    class University
    {
        public List<Department> Departments { get; set; } = [];
        public void AddDep(string name, string director, AllDepartments department, int num)
        {
            if (department == AllDepartments.arts)
            {
                Departments.Add(new ArtsDepartment { Name = name, Director = director, NumberOfStudents = num });
            }
            else if (department == AllDepartments.comp)
            {
                Departments.Add(new CompDepartment { Name = name, Director = director, NumberOfComputerLabs = num });
            }
        }
    }
}
