//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// 4. Метод упорядочит по убыванию элементы каждой строки двумерного массива
void Streamline(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int count = 0; count < arr.GetLength(1) - 1 ; count++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    int buffer = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = buffer;
                }
            }
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

// 4. Упорядочить по убыванию элементы каждой строки двумерного массива
Streamline(matrix);

// Вывод пустой строки для визуального разделения массивов
System.Console.WriteLine();

// 5. Вывод изменённого массива в терминал 
ShowMatrix(matrix);