// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
double [,] CreateArray(int r, int c)
{
    double [,] array = new double [r,c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            array[i,j]=new Random().Next(-10,10)+new Random().NextDouble();
        }
    }
    return array;
}
void PrintArray(double[,]array)// Вывод массива на экран
{
   int rows = array.GetUpperBound(0) + 1;   
    int columns = array.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i,j]<0) Console.Write($"{array[i,j]:N1} \t");
            else Console.Write($" {array[i,j]:N1} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Введите размерность массива: ");
Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,]array=CreateArray(m,n);
PrintArray(array);

