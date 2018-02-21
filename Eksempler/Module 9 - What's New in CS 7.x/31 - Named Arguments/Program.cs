using System;

namespace CS7.Slide31
{
    class Program
    {
        static void M( int x, int y = 87, bool z = default )
        {
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");
        }

        static void Main( string[] args )
        {
            M(1, 2, true);
            M(x: 1, 2, z: true);
            // M(z: true, 1 );
        }
    }
}
