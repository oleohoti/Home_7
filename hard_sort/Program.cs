// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10
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
int [] ConvertIn(int [,]array,int m, int n) // переводим двумерный массив в одномерный 
{
    int g=0;
    int[]array1=new int [m*n];
    
        
        
    
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                 array1[g]=array[i,j];g++;
                }
            }
        

    return array1;
}
int [] Arrange(int[]array)// Упорядочивание массива
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j]<array[minPosition])
            {
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i]=array[minPosition];
        array[minPosition] = temporary;
    }
    return array;
}
int [,] ConvertOut(int []array,int m,int n) // переводим одномерный массив в двумерный 
{
    int g=0;
    int[,]array1=new int [m,n];
            for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array1[i,j]=array[g];g++;
                
            }
        }
    return array1;
}
Console.WriteLine("Введите размерность массива: ");
Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,]array= CreateArray2(m,n);
PrintArray(array);
int[]array1=ConvertIn(array,m,n);
int[]arraysort=Arrange(array1);
int[,]arrayout=ConvertOut(arraysort,m,n);
PrintArray(arrayout);
