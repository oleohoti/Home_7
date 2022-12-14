// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int [,] CreateArray2(int r,int c)// Создание массива рандомных чисел
{
    int [,] array = new int [r,c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            array[i,j]=new Random().Next(0,10);
        }
    }
    return array;
}
void PrintArray(int[,]array)// Вывод массива на экран
{
   int rows = array.GetUpperBound(0) + 1;   // строки
    int columns = array.Length / rows;  // столбцы
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i,j]<0) Console.Write($"{array[i,j]:N1} \t");
            else Console.Write($" {array[i,j]:N0} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[,] ConvertArray(int[,]array,int m,int n)
{
    double [,]arrayd=new double[m,n];
    int rows = array.GetUpperBound(0) + 1;    // количество строк
    int columns = array.Length / rows;        // количество столбцов
// или так
// int columns = numbers.GetUpperBound(1) + 1;
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arrayd[i,j]=Convert.ToDouble(array[i,j]);
    }
    
}
return arrayd;
}
double[] Middle(double [,]array,double []sum)// Метод нахождения среднего арифметического
{
    double[]middle=new double [sum.Length];
    int rows = array.GetUpperBound(0) + 1;    // количество строк
    int columns = array.Length / rows;        // количество столбцов
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            sum[i]+=array[j,i];
        }
        middle[i]=sum[i]/rows;
    }
    return middle;
}
void Info(double[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Среднее арифметическое {i}-го столбца равно: {array[i]:N1}");
    }
    
}
Console.WriteLine("Введите размерность массива: ");
Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,]array= CreateArray2(m,n);
PrintArray(array);
double[,] arrayd = ConvertArray(array, m, n);
double[]sum = new double[n];
double[]middle = Middle(arrayd,sum);
Info(middle);
