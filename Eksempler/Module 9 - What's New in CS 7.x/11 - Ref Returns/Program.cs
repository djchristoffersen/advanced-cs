using static System.Console;

namespace CS7.Slide11
{
    class Program
    {
        static int FindMax(int[] numbers)
        {
            int indexOfMax = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[indexOfMax])
                {
                    indexOfMax = i;
                }
            };

            return numbers[indexOfMax];
        }

        static void Main(string[] args)
        {
            int[] numbers = { 112, 176, 42, 87, 99 };

            int max = FindMax(numbers);
            WriteLine($"{nameof(max)} is now {max}");

            // max = 1000;

            WriteLine("Numbers are:");
            foreach (int i in numbers)
            {
                WriteLine(i);
            }

            #region Shocker!

            //FindMax(numbers) = 99999;

            #endregion
        }
    }
}
