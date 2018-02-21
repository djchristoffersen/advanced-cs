using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS7.Slide23
{
    struct Equipment
    {
        public string Console { get; set; }
        public int Controllers { get; set; }
        public bool IsVREnabled { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Equipment e = new Equipment
            {
                Console = "PlayStation 4",
                Controllers = 2,
                IsVREnabled = true
            };

            var tuple = (e.Console, e.Controllers);

            // Console.WriteLine( tuple.Console );
        }
    }
}
