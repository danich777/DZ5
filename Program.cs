// Урок 5. Функции продолжение
// Все массивы от 5-ти элементов

/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = GetArray(5, 100, 1000);
Console.WriteLine(String.Join(" ", array));

int evenNumbers = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        evenNumbers++;
    }
}

Console.WriteLine($"Количество четных чисел в массиве {evenNumbers} ");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] array = GetArray(5);
Console.WriteLine(String.Join(" ", array));

int summ = 0;

for (int i = 0; i < array.Length; i+=2)
{
   summ = summ + array[i];
} 

Console.WriteLine($"Сумма элементов на нечетных позициях равна {summ} ");


int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100);
    }
    return res;
}
*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

float[] array = GetArray(5);
Console.WriteLine(String.Join(" ", array));

float maxArray = array[0];
float minArray = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minArray)
    {
        minArray = array[i];
    }
    else if (array[i] > maxArray)
    {
        maxArray = array[i];
    }
}

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {maxArray - minArray} ");


float[] GetArray(int size)
{
    float[] res = new float[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100);
    }
    return res;
}

