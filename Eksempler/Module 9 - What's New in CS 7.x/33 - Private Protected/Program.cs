using System;

namespace CS7.Slide33
{
    class DerivedFromOtherAssembly : OtherData.ClassInOtherAssembly
    {
        public DerivedFromOtherAssembly( int x )
        {
            X = x;
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            var example = new DerivedFromOtherAssembly(87);
            //Console.WriteLine(example.X); // Not allowed!

            example.Print();
        }
    }
}
