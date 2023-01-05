// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// 4. Метод умножения матриц

void ResultOfMultiplicationTwoMatrix(int[,]first, int [,] second, int [,] product)
{
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            int sum = 0;
            sum += first[i, j] * second[i, j];
            product[i, j] = sum; 

        }
    }
}

// 3. Метод выводит массив в терминал
void ShowMatrix(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write("[" + arr[i, j] + "] ");
        }
        System.Console.WriteLine();
    }
}

// 2. Метод заполняет массив рандомно
void ArrayWithRundomNumbers(int[,] arr, int leftRange, int rightRange)
{
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }
}

// 1. Метод спрашивает пользователя ввести число
int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// ================================================================================================

// 1. Пользователь вводит размеры массивов и границы цифр
int rowsFirstMatrix = EnterNumber("Введите кол-во строк первой матрицы: ");
int columnsFirstMatrix = EnterNumber("Введите кол-во столбцов первой матрицы: ");

int rowsSecondMatrix = EnterNumber("Введите кол-во строк второй матрицы: ");
int columnsSecondMatrix = EnterNumber("Введите кол-во столбцов второй матрицы: ");

int min = EnterNumber("Укажите левую границу цифр: ");
int max = EnterNumber("Укажите правую границу цифр: ");

if(rowsFirstMatrix == columnsSecondMatrix)
{
    // Создаются двумерные массивы
    int[,] firstMatrix = new int[rowsFirstMatrix, columnsFirstMatrix];
    int[,] secondMatrix = new int[rowsSecondMatrix, columnsSecondMatrix];

    // 2. Заполнение матриц случайными числами
    ArrayWithRundomNumbers(firstMatrix, min, max);
    ArrayWithRundomNumbers(secondMatrix, min, max);

    // 3. Вывод первого массива в терминал 
    ShowMatrix(firstMatrix);

    // Вывод пустой строки для визуального разделения массивов
    System.Console.WriteLine();

    // 3. Вывод второго массива в терминал 
    ShowMatrix(secondMatrix);

    // Создаётся двумерный массив - результат произведения двух матриц
    int [,] multiplicationMatrix = new int [rowsFirstMatrix, columnsSecondMatrix];

    // 4. Умножение двух матриц 
    ResultOfMultiplicationTwoMatrix(firstMatrix, secondMatrix, multiplicationMatrix);

    System.Console.WriteLine();
    ShowMatrix(multiplicationMatrix);
}
else
    System.Console.WriteLine("Матрицы нельзя перемножить");