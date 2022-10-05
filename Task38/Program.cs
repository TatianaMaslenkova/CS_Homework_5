// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] array = new double[10];
FillArray(array);
PrintArray(array);
double diff = DiffMaxMin(array);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {diff}");

void FillArray(double[] array)
{
    Random randGenegator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenegator.NextDouble();
    }
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i == array.Length - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }    
}

double DiffMaxMin(double[] array)
{
    double diff = 0;
    double max = array.Max();
    double min = array.Min();
    diff = Math.Round((max - min), 2);
    return diff;
}
