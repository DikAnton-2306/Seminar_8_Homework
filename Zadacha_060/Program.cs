// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void PrintCube(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                System.Console.Write($"{arr[i, j, k]} ({i}, {j}, {k}) ");
            }
            System.Console.WriteLine();
        }
    }
}

void FillCubeRandomNumbers(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int cubeSize = EnterNumber("Введите размер трехмерного масива");
int[,,] cube = new int[cubeSize, cubeSize, cubeSize];
FillCubeRandomNumbers(cube);
PrintCube(cube);