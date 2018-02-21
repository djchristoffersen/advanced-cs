using System;

namespace CS7.Slide32
{
    class Program
    {
        static void Main( string[] args )
        {
            int i = 0b00_00_00_00_00_00_01;  // Allowed in C# 7.0
            int j = 0b_00_00_00_00_00_00_01; // Allowed in C# 7.2
            int k = 0x_ffff;                 // Allowed in C# 7.2
            //int m = 8_7;
            //int n = _8_7;

            Console.WriteLine( i );
            Console.WriteLine( j );
        }
    }
}
