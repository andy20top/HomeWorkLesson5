// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArrayThreeDigit(int size)
{
    int[] array = new int [size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(100, 1000);
    } 
    return array;
}

int length = 7;
int[] array = FillArrayThreeDigit(length);
System.Console.WriteLine(string.Join(" ", array));

int CountEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

System.Console.WriteLine($"Количество четных элементов - {CountEvenNumber(array)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray (int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(minValue, maxValue+1);
    } 
    return array;
}

int SumOddPosition (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

System.Console.WriteLine("______________________________");

int[] sumArray = FillArray(length, 1, 10);
System.Console.WriteLine(string.Join(" ", sumArray));
System.Console.WriteLine($"Сумма элементов на нечетных позициях - {SumOddPosition(sumArray)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] FillDoubleArray(int size)
{
    double[] array = new double [size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * 100, 2);
    }
    return array;
}

double MinInArray (double[] array)
{
    double minValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
        }
    }
    return minValue;
}

double MaxInArray (double[] array)
{
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }
    return maxValue;
}

double DiffMaxMin (double[] array)
{
    double diff = MaxInArray(array) - MinInArray(array);
    return diff;
}

System.Console.WriteLine("______________________________");

double[] arrayDouble = FillDoubleArray(5);
System.Console.WriteLine(string.Join(" ", arrayDouble));
System.Console.WriteLine($"Разница между максимальным и минимальным - {DiffMaxMin(arrayDouble)}");