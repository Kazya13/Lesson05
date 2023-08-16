// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double roundNum = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{roundNum}, ");
        else Console.Write($"{roundNum}");
    }
    Console.Write("]");
}

double MinElementOfArray(double[] arr)
{

    double minNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(minNum > arr[i]) minNum = arr[i];
    }
    return minNum;
}

double MaxElementOfArray(double[] arr)
{
    double maxNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(maxNum < arr[i]) maxNum = arr[i];
    }
    return maxNum;
}

Console.WriteLine();
double[] array = CreateArrayRndDouble(5, -10, 10);
PrintArrayDouble(array);
Console.WriteLine();
Console.WriteLine();

double min = Math.Round(MinElementOfArray(array), 1);
double max = Math.Round(MaxElementOfArray(array), 1);
Console.WriteLine($"Min -> {min}");
Console.WriteLine($"Max -> {max}");
Console.WriteLine();

Console.Write($"Результат -> {Math.Round((max - min), 1)}");
Console.WriteLine();
PrintArrayDouble(array);
Console.Write($" => [{max}] - [{min}] = {Math.Round((max - min), 1)}");