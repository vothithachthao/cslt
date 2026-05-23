using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MatrixProgram
{
    static void Main()
    {
        // 1. Prompt for N and M
        Console.Write("Enter number of rows (N): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns (M): ");
        int m = int.Parse(Console.ReadLine());
        // 2. Create and Print Matrix
        int[,] matrix = CreateMatrix(n, m);
        Console.WriteLine("\nGenerated Matrix");
        PrintMatrix(matrix);
        // 3. Prompt for index i
        Console.Write("\nEnter index i to fetch row/col & min values: ");
        int i = int.Parse(Console.ReadLine());
        // Row Operations
        if (i >= 0 && i < n)
        {
            PrintRow(matrix, i);
            Console.WriteLine($"Min value in Row {i}: {FindMinInRow(matrix, i)}");
        }
        else Console.WriteLine($"Index {i} is out of bounds for rows.");
        // Column Operations
        if (i >= 0 && i < m)
        {
            PrintColumn(matrix, i);
            Console.WriteLine($"Min value in Column {i}: {FindMinInCol(matrix, i)}");
        }
        else Console.WriteLine($"Index {i} is out of bounds for columns.");

        // 4. Global Max
        Console.WriteLine($"\nMaximum value in the entire matrix: {FindMax(matrix)}");
        // 5. Transpose
        Console.WriteLine("\nTransposed Matrix");
        int[,] transposed = Transpose(matrix);
        PrintMatrix(transposed);
        // 6. Diagonals (Square Matrix Check)
        if (n == m)
        {
            PrintDiagonals(matrix);
        }
        else
        {
            Console.WriteLine("\nMatrix is not square; skipping diagonals.");
        }
    }
    static int[,] CreateMatrix(int n, int m)
    {
        Random rand = new Random();
        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                matrix[i, j] = rand.Next(1, 100); // Random 1-99
        return matrix;
    }
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
    }
    static void PrintRow(int[,] matrix, int rowIdx)
    {
        Console.Write($"Row {rowIdx}: ");
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[rowIdx, j] + " ");
        Console.WriteLine();
    }
    static void PrintColumn(int[,] matrix, int colIdx)
    {
        Console.Write($"Col {colIdx}: ");
        for (int i = 0; i < matrix.GetLength(0); i++)
            Console.Write(matrix[i, colIdx] + " ");
        Console.WriteLine();
    }
    static int FindMax(int[,] matrix)
    {
        int max = matrix[0, 0];
        foreach (int val in matrix) if (val > max) max = val;
        return max;
    }
    static int FindMinInRow(int[,] matrix, int rowIdx)
    {
        int min = matrix[rowIdx, 0];
        for (int j = 1; j < matrix.GetLength(1); j++)
            if (matrix[rowIdx, j] < min) min = matrix[rowIdx, j];
        return min;
    }
    static int FindMinInCol(int[,] matrix, int colIdx)
    {
        int min = matrix[0, colIdx];
        for (int i = 1; i < matrix.GetLength(0); i++)
            if (matrix[i, colIdx] < min) min = matrix[i, colIdx];
        return min;
    }
    static int[,] Transpose(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] result = new int[cols, rows];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[j, i] = matrix[i, j];
        return result;
    }
    static void PrintDiagonals(int[,] matrix)
    {
        int size = matrix.GetLength(0);
        Console.WriteLine("\nDiagonals");
        Console.Write("Main Diagonal: ");
        for (int i = 0; i < size; i++) Console.Write(matrix[i, i] + " ");
        Console.Write("\nSecondary Diagonal: ");
        for (int i = 0; i < size; i++) Console.Write(matrix[i, size - 1 - i] + " ");
        Console.WriteLine();
    }
}