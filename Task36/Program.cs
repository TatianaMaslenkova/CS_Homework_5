// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);

int sum = SumofOddNum(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");

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

int SumofOddNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            count = count + array[i];
        }
    }
    return count;
}