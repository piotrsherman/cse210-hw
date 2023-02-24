using System;

class Program
{
    static void Main(string[] args)
    {
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter numbers to add to the list (enter 0 to stop):");
            int input = int.Parse(Console.ReadLine());
            while (input != 0)
            {
                numbers.Add(input);
                input = int.Parse(Console.ReadLine());
            }

            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();

            Console.WriteLine("Sum of the numbers: " + sum);
            Console.WriteLine("Average of the numbers: " + average);
            Console.WriteLine("Maximum number: " + max);

            Console.ReadLine();
    }
}