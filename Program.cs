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

