// В матрице чисел найти сумму элементов главной диагонали
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
int SummDiagonal(int[,] array)
{
    int sum = 0;
    for (int m = 0; m < array.GetLength(0); m ++)
    {
        for (int n = 0; n < array.GetLength(1); n ++)
        {
            if (m == n){
                sum = sum + array[m, n];
            }
        }
    }
    return sum;
}

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
SummDiagonal(array);
Console.WriteLine($"Сумма элементов диагонали:{SummDiagonal(array)}");
