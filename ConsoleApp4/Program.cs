using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] a = new int[10, 10];

        Console.WriteLine("Enter values for the a:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"Enter value for [{i}, {j}]: ");
                int val = int.Parse(Console.ReadLine()!);
                a[i, j] = val;
            }
        }
        Console.WriteLine("Enter the two numbers:");
        int num1 = int.Parse(Console.ReadLine()!);
        int num2 = int.Parse(Console.ReadLine()!);

        bool found = false;
        for (int column = 0; column < 10; column++)
        {
            int row1 = -1, row2 = -1;
            for (int row = 0; row < 10; row++)
            {
                if (a[row, column] == num1)
                {
                    row1 = row;
                }
                if (a[row, column] == num2)
                {
                    row2 = row;
                }
            }
            if (row1 != -1 && row2 != -1)
            {
                Console.WriteLine(num1 + " found: " + $"[{row1}, {column}]");
                Console.WriteLine(num1 + " found: " + $"[{row2}, {column}]");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Not Found!");
        }
    }
}