int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
double[] GetAverColum(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    for(int i = 0; i < inArray.GetLength(1); i++)
    {
        double sum = 0;
        for(int j = 0; j < inArray.GetLength(0); j++)
        {
            sum = sum + inArray[j, i];
        }
        result[i] = Math.Round(sum / inArray.GetLength(0), 2);
    }
    return result;
}
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("Средние значения элементов столбцов:");
double[] resArray = GetAverColum(array);
Console.Write(String.Join(", ", resArray));