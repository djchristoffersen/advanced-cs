using static System.Console;

namespace CS7.Slide16
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = ReadLine();
            int result;
            if (int.TryParse(s, out result))
            {
                WriteLine(result);
            }

            // result also visible here...
            // WriteLine( result );
        }
    }
}
