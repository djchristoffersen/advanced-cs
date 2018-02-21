using CS7.Data;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace CS7.Slide15
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
            IEnumerable<Employee> banzaiRaccoons = repository.GetAll();

            repository.Add(null);

            //repository.Add(new Employee { FirstName = "Anders", LastName = "Hejlsberg" });

            repository
                .GetAll()
                .Select(e => e.FirstName)
                .ToList()
                .ForEach(WriteLine);
        }
    }
}
