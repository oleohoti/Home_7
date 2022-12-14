
// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
int [,] CreateArray(int r,int c)
{
    int [,] array = new int [r,c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            array[i,j]=new Random().Next(1,10);
        }
    }
    return array;
}
void PrintArray(int[,]array)// Вывод массива на экран
{
   int rows = array.GetUpperBound(0) + 1;   
    int columns = array.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i,j]<0) Console.Write($"{array[i,j]} \t");
            else Console.Write($" {array[i,j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FindNum(int num, int[,] array)
{
    int r=0; int c=0;
    bool m=false;
    int rows = array.GetUpperBound(0) + 1;   
    int columns = array.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i,j]==num) {m=true;r=i;c=j;Console.WriteLine($"Число {num} находится в {r} строке, в {c} столбце.");}
            
        }
    }
    if (m!=true) Console.WriteLine("Такого числа в массиве не обнаружено");
}
try
{
Console.WriteLine("Введите размерность массива: ");
Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,]array=CreateArray(m,n);
PrintArray(array);
Console.WriteLine("Введите значение элемента массива, позицию которого необходимо вывести на экран: ");
int num=Convert.ToInt32(Console.ReadLine());
FindNum(num,array);
}
catch
{
    Console.WriteLine("Вводите пожалуйста целые числа!");
}

