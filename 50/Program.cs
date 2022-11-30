/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

using static System.Console;
Clear();


WriteLine("Введите число: ");
int namber = int.Parse(ReadLine());

int[,] mat = GetMatrix(4, 4);

PrintMatrix(mat);


int[,] GetMatrix(int rows, int colums)
{
    int[,] result = new int[rows, colums];
  
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(0,10);
        }
    }
    return result;

}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]}\t ");
        }
        WriteLine();
    }

}


for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i,j] == namber) 
            {
             
            
             Write($"значение этого элемента ({(i)},{(j)})");
             break;
             
            }
        }
        
        
    } 

     
        
