// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите трёхзначные числа через пробел: ");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);

int i = 0; 
if ((array[i] < 100) || (array[i] > 999))
{
    Console.WriteLine("Нужно ввести трёхзначные числа!");
}
else
{
    int evenNumCount = FindEvenNum(array);
    Console.WriteLine($"Количество чётных чисел в массиве: {evenNumCount}");
}
i++;

int[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
    return result;
}

int FindEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}