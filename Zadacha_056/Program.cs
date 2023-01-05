// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// 4. Метод нахождения и вывода номера строки массива с минимальной суммой элементов

void FindMinLine(int[,] arr)
{
    int minLine = 0;
    int sumMinLine = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sumMinLine += arr[0, j];
    }
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int sumLine = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumLine += arr[i, j];
        }
        if(sumMinLine > sumLine)
        {
            minLine = i;
            sumMinLine = sumLine;
        }
    }
    System.Console.WriteLine($"Строка с минимальной суммой элементов : {minLine + 1}");
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

// 1. Пользователь вводит размер массива и границы цифр
int rows = EnterNumber("Введите кол-во строк: ");
int columns = EnterNumber("Введите кол-во столбцов: ");

int min = EnterNumber("Укажите левую границу цифр: ");
int max = EnterNumber("Укажите правую границу цифр: ");

// 2. Создаётся двумерный массив
int[,] matrix = new int[rows, columns];
ArrayWithRundomNumbers(matrix, min, max);

// 3. Вывод массива в терминал 
ShowMatrix(matrix);

// Вывод пустой строки для визуального разделения массивов
System.Console.WriteLine();

// 4. Нахождение и вывод номера строки массива с минимальной суммой элементов 
FindMinLine(matrix);