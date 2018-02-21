using CS7.Data;
using System;
using System.Collections.Generic;
using static System.Console;

namespace CS7.Slide07
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
            IEnumerable<Employee> banzaiRaccoons = repository.GetAll();

            foreach (Employee e in banzaiRaccoons)
            {
                //For software engineers:
                //
                //WriteLine($"{se.FullName} has produced {se.CodeLinesProduced} lines of C#");
            }
        }
    }
}
