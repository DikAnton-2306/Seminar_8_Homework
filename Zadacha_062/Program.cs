// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
                System.Console.Write("[" + 0 + arr[i, j] + "] ");
            else
                System.Console.Write("[" + arr[i, j] + "] ");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];
int i = 0;
int j = 0;
int buferJ = 0;
int buferI = 0;
int count = 1;
for (int index = 0; index < matrix.GetLength(1); index++)
{
    for (j = index; j < matrix.GetLength(1); j++)
    {
        if (matrix[buferI, j] == 0)
        {
            matrix[i + index, j] = count;
            count++;
            buferJ = j;
        }
        else break;
    }
    for (i = index + 1; i < matrix.GetLength(0); i++)
    {
        if (matrix[i, buferJ] == 0)
        {
            matrix[i, buferJ] = count;
            count++;
            buferI = i;
        }
        else break;
    }
    for (j = buferJ - 1; j >= 0; j--)
    {
        if (matrix[buferI, j] == 0)
        {
            matrix[buferI, j] = count;
            count++;
            buferJ = j;
        }
        else break;
    }
    for (i = buferI - 1; i >= 0; i--)
    {
        if (matrix[i, buferJ] == 0)
        {
            matrix[i, buferJ] = count;
            count++;
            buferI = i;
        }
        else break;
    }    

}
PrintMatrix(matrix);
