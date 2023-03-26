void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 345);
}
int Even(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) res++;
    }
    return res;
}
void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}
int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Количество чётных чисел в массиве: {Even(array)}");