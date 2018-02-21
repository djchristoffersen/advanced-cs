using CS7.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CS7.Slide17
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
            IEnumerable<Employee> banzaiRaccoons = repository.GetAll();

            foreach (Employee e in banzaiRaccoons)
            {
                Promote(e);
            }
        }

        static void Promote<T>( T employee )
        {
            //switch (employee)
            //{
            //    case SoftwareArchitect sa:
            //        sa.Level = SoftwareArchitectLevel.Lead;
            //        break;

            //    case SoftwareEngineer se:
            //        se.Level = SoftwareEngineerLevel.Chief;
            //        break;
            //}
        }
    }
}
