//адача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
// 1 4 7 2                                  
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using static System.Console;
Clear();


WriteLine("Введите количество строк m: ");
int rows= int.Parse(ReadLine());
WriteLine("Введите количество столбцов n: ");
int colums = int.Parse(ReadLine());

int[,] array = new int[rows, colums];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] =  new Random().Next(0,10);
        }
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Write($"{array[i, j]}\t ");
        }
        WriteLine();
    }

for (  int j=0; j < colums;j++)
{
    double summ = 0;

     for (int i = 0; i < rows;i++)
    summ+=array[i,j];
    Console.WriteLine($"среднее арифметическое {(j+1)} столбца = {(summ/rows)}");
     }
      