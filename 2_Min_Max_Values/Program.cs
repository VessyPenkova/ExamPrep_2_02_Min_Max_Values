namespace _2_Min_Max_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            int maxValue = int.MinValue;
            int minValue = int.MaxValue;

            if (n > numbers.Length)
            {
                n = numbers.Length;
            }

            for (int i = 0; i < n; i++)
            {
                int currentNumber = numbers[i];

                if (maxValue < currentNumber )
                {
                    maxValue = currentNumber;
                }
                if (minValue > currentNumber)
                {
                    minValue = currentNumber;
                }
            }

            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
        }

    }
}
