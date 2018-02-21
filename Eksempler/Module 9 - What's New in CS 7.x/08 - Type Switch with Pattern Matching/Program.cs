using CS7.Data;
using System.Collections.Generic;
using static System.Console;

namespace CS7.Slide08
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
            IEnumerable<Employee> banzaiRaccoons = repository.GetAll();

            foreach (Employee e in banzaiRaccoons)
            {
                switch (e)
                {
                    case SoftwareArchitect sa:
                        WriteLine($"{sa.FullName} plays with Visio");
                        break;

                    case SoftwareEngineer se:
                        WriteLine($"{se.FullName} has a fun job coding all day");
                        break;

                    case null:
                    default:
                        break;
                }

                #region when

                //case SoftwareEngineer se when se.Level == SoftwareEngineerLevel.Lead:
                //    WriteLine($"{se.FullName} is a lead software engineer");
                //    break;

                #endregion
            }
        }
    }
}
