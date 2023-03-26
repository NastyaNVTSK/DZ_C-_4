void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 50);
}
int Summ(int[] array)
{
    int sum = 0;
    int i = 0;
    while(i<array.Length)
    {
        sum += array[i];
        i = i + 2;
    }
    return sum;
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
Console.WriteLine($"Сумма элементов нечетных позиций: {Summ(array)}");