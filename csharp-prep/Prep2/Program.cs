using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        char letter;
        if (gradePercentage >= 90)
        {
            letter = 'A';
        }
        else if (gradePercentage >= 80)
        {
            letter = 'B';
        }
        else if (gradePercentage >= 70)
        {
            letter = 'C';
        }
        else if (gradePercentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (letter != 'F' && gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

        char sign = '\0';
        if (letter == 'A')
        {
            if (gradePercentage <= 92)
            {
                sign = '-';
            }
        }
        else if (letter == 'B')
        {
            if (gradePercentage >= 87)
            {
                sign = '+';
            }
            else if (gradePercentage <= 82)
            {
                sign = '-';
            }
        }
        else if (letter == 'C')
        {
            if (gradePercentage >= 77)
            {
                sign = '+';
            }
            else if (gradePercentage <= 72)
            {
                sign = '-';
            }
        }

        if (sign != '\0')
        {
            Console.WriteLine($"Your letter grade with sign is {letter}{sign}.");
        }
    }
}