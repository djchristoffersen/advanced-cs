using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CS7.Slide22
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int i = flag ? 87 : default(int);

            WriteLine( i );
        }

        //static void DoStuff( int x, int y = default, bool z = default )
        //{
        //    WriteLine( $"x={x}\ty={y}\tz={z}");
        //}
    }
}
