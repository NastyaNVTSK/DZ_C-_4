void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble();
}
double Diff(double[] array)
{
    int i = 1;
     double min = array[0];
     double max = array[0];
    while(i<array.Length)
    {
        if(max<array[i])
        max = array[i];
         if(min>array[i])
        min = array[i];
        i++;
    }
    return max-min;
}
void PrintArray(double[] array)
{
    foreach (double item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}
double [] array = new double[4];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Разница: {Diff(array)}");