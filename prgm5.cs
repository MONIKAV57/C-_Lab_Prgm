using System;

class PascalTriangle
{
    static void Main(string[] args)
    {
        int rows;
        Console.Write("Enter the number of rows for Pascal's Triangle: ");
        rows = int.Parse(Console.ReadLine());

        int[,] triangle = new int[rows, rows];

        // Fill the triangle with Pascal's Triangle values
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                    triangle[i, j] = 1;
                else
                    triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
            }
        }

        // Print Pascal's Triangle
        Console.WriteLine("Pascal's Triangle:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(triangle[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
