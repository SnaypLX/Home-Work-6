// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты


void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
void Change(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m = m + 2)
    {
        for (int n = 0; n < array.GetLength(1); n = n + 2)
        {
         array[m, n] = array[m, n] * array[m, n];
         
        }
    }
}





Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];





FillArray(array);
PrintArray(array);
Console.WriteLine();
Change(array);
PrintArray(array);
