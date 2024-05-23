// Семинар 5 - Двумерные массивы

/* Задача 1 - Найдите произведения пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новый массив.

Пример:
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)
*/
/*
int [] CreateArray(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,10);
    }
    return array;
}
void ShowArray(int [] array)
{
    foreach (int e in array)
        Console.Write($"{e} ");
    Console.WriteLine();
}
int [] CreateNewArray(int [] array)
{
    int newSize = array.Length/2;
    int [] newArray = new int [newSize];
    for (int i = 0; i < newSize; i++)
    {
        newArray[i]=array[i]*array[array.Length-1-i];
    }
    return newArray;
}

Console.Write("Введите количество элементов массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int [] arrayTask1 = CreateArray(arraySize);
ShowArray(arrayTask1);
int [] result = CreateNewArray(arrayTask1);
ShowArray(result);
*/

/* Задача 2 - Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Пример:
2 3 4 3      4 3 4 3
4 3 4 1  =>  4 3 4 1
2 9 5 4      2 9 25 4
*/
/*
// Важно: .GetLenght(0) - Строки --- .GetLenght(1) - Столбцы и т.д.

// Создание массива --> Демонстрация массива --> Возведение в квадрат нужных элементов

int[,] Create2DArray(int row, int collumn) // Создание массива
{
    int[,] created2DArray = new int[row, collumn];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < collumn; j++)
            created2DArray[i,j] = new Random().Next(0,10);
    return created2DArray;
}
void Show2DArray(int [,] array2D) // Демонстрация массива
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            Console.Write($"{array2D[i,j]} ");
        Console.WriteLine();
    }       
}
int[,] SquaredElem(int[,] array2D) // Возведение в квадрат нужных элементов
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array2D[i,j] *= array2D[i,j];
            }
        }    
    }
    return array2D;
}

Console.Write("Введите количество строк двумерного массива:");
int arrayRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива:");
int arrayCollumns = Convert.ToInt32(Console.ReadLine());
int [,] array2DTask2 = Create2DArray(arrayRow,arrayCollumns);
Show2DArray(array2DTask2);
int [,] resultArray2D = SquaredElem(array2DTask2);
Console.WriteLine("Получившийся массив:");
Show2DArray(resultArray2D);
*/

/* Задача 3 - Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Пример:
2 3 4 3
4 3 4 1 => 2 + 3 + 5 = 10
2 9 5 4
*/
/*
// Создание массива --> Демонстрация массива --> Сложение элементов типа (0,0), (1,1) и т.п.

int [,] Create2DArray(int row, int collumn)
{
    int [,] array2D = new int [row,collumn];
    for (int i = 0; i < array2D.GetLength(0); i++)
        for (int j = 0; j < array2D.GetLength(1); j++)
            array2D[i,j] = new Random().Next(0,10);
    return array2D;
}
void Show2DArray(int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            Console.Write($"{array2D[i,j]} ");
        Console.WriteLine();
    }    
}
int SumElemMainDiagonale(int[,] array2D)
{
    int sum = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
        for (int j = 0; j < array2D.GetLength(1); j++)
            if (i == j)
                sum += array2D[i,j];
    return sum;
}


Console.Write("Введите количество строк двумерного массива:");
int arrayRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива:");
int arrayCollumns = Convert.ToInt32(Console.ReadLine());
int [,] array2DTask3 = Create2DArray(arrayRow,arrayCollumns);
Show2DArray(array2DTask3);
int resultTask3 = SumElemMainDiagonale(array2DTask3);
Console.WriteLine($"Сумма элементов главной диагонали: {resultTask3}");
*/

/* Задача 4 - Задайте двумерный массив из целых чисел. 
Сформируйте новый одномерный массив, состоящий из средних арифметических значений 
по строкам двумерного массива.

Пример:
2 3 4 3
4 3 4 1 => [3 3 5]
2 9 5 4
*/
/*
int [,] Create2DArray(int row, int collumn)
{
    int [,] array2D = new int [row,collumn];
    for (int i = 0; i < array2D.GetLength(0); i++)
        for (int j = 0; j < array2D.GetLength(1); j++)
            array2D[i,j] = new Random().Next(0,10);
    return array2D;
}
void Show2DArray(int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            Console.Write($"{array2D[i,j]} ");
        Console.WriteLine();
    }    
}
double [] ArrayOfAverageString(int [,] array2D)
{
    double [] arrayAverageString = new double [array2D.GetLength(0)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
            sum += array2D[i,j];
        double average = sum / array2D.GetLength(1);
        arrayAverageString[i] = Math.Round(average, 3);
    }        
    return arrayAverageString;
}
void ShowArray(double [] array)
{
    foreach (double e in array)
        Console.Write($"{e} ");
}

Console.Write("Введите количество строк двумерного массива:");
int arrayRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива:");
int arrayCollumns = Convert.ToInt32(Console.ReadLine());
int [,] array2DTask4 = Create2DArray(arrayRow,arrayCollumns);
Show2DArray(array2DTask4);
double [] resultArrayTask4 = ArrayOfAverageString(array2DTask4);
Console.WriteLine($"Среднее арифметическое каждой строки:");
ShowArray(resultArrayTask4);
*/


// Домашнее задание!

/* Задание 1 - Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет: 
"Позиция по рядам выходит за пределы массива" или "Позиция по колонкам выходит за пределы массива"

Позиции в массиве считать от единицы.

Пример:
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}

int x = 2;
int y = 2;

Выводится: 6
*/
/*
int [,] Create2DArray(int row, int collumn)
{
    int [,] array2D = new int [row,collumn];
    for (int i = 0; i < array2D.GetLength(0); i++)
        for (int j = 0; j < array2D.GetLength(1); j++)
            array2D[i,j] = new Random().Next(0,10);
    return array2D;
}
void Show2DArray(int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            Console.Write($"{array2D[i,j]} ");
        Console.WriteLine();
    }    
}
bool IsItValidte (int [,] array, int x, int y)
{
    if (x <= 0 || x > array.GetLength(0))
        {
          System.Console.Write("Позиция по рядам выходит за пределы массива");
          return false;
        }
        if (y<=0 || y > array.GetLength(1))
        {
          System.Console.Write("Позиция по колонкам выходит за пределы массива");
          return false;
        }
    return true;
}
int FindElementByPosition(int[,] array, int x, int y)
{
    return array[x-1,y-1];
}

int [,] HWarrayTask1 = Create2DArray(3,4);
Show2DArray(HWarrayTask1);
Console.Write("Введите строку для поиска необходимого элемента:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец для поиска необходимого элемента:");
int y = Convert.ToInt32(Console.ReadLine());
if (IsItValidte(HWarrayTask1, x, y)== true)
    Console.WriteLine($"Элемент: {FindElementByPosition(HWarrayTask1,x,y)}");
*/

/* Задание 2 - Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.

Пример:
1 2  3  4        9   10  11  12 
5 6  7  8   -->  5   6   7   8 
9 10 11 12       1   2   3   4 

Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены табуляцией.
*/
/*
using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Печать массива
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

// Обмен первой с последней строкой
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        for (int i = 0; i < array.GetLength(1); i++) {
            SwapItems(array, i);
        }
        return array;
    }

// Обмен элементами массива
    public static void SwapItems(int[,] array, int i)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }

    public static void PrintResult(int[,] numbers)
    {
        PrintArray(SwapFirstLastRows(numbers));
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            }; 
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}
*/

/* Задание 3 - Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Пример:
1 2 3
1 1 0
7 8 2 ==> 1 строка
9 9 9
*/
/* Решение Автотеста
using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
        int[] sum = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum[i] += array[i, j];
            }
        }
        return sum;
    }

    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    {
        int minI = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[minI] > array[i])
            {
                minI = i;
            }
        }
        return minI;
    }
    public static void PrintResult(int[,] numbers)
    {   
        int[] sums = SumRows(numbers);
        int minIndex = MinIndex(sums);
        Console.Write(minIndex);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив

            numbers = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
    };      
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}
*/

/* //Мое решение

int [,] Create2DArray(int row, int collumn)
{
    int [,] array2D = new int [row,collumn];
    for (int i = 0; i < array2D.GetLength(0); i++)
        for (int j = 0; j < array2D.GetLength(1); j++)
            array2D[i,j] = new Random().Next(0,10);
    return array2D;
}
void Show2DArray(int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            Console.Write($"{array2D[i,j]} ");
        Console.WriteLine();
    }    
}
int FindMaxRowSum(int [,] array2D)
{
    int indexMaxRow = 0;
    int maxSumRow = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
        {   
            int sumRow = 0;
            for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    sumRow += array2D[i,j];
                }
            if (sumRow > maxSumRow)
                {
                    maxSumRow = sumRow;
                    indexMaxRow = i+1;
                }
        }
    return indexMaxRow;
}

Console.Write("Введите количество строк двумерного массива:");
int arrayRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива:");
int arrayCollumns = Convert.ToInt32(Console.ReadLine());
int [,] array2DHW3 = Create2DArray(arrayRow,arrayCollumns);
Show2DArray(array2DHW3);
int result = FindMaxRowSum(array2DHW3);
Console.Write($"Строка с максимальной суммой элементов: {result}");
*/