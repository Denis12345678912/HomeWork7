// .Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет
//строка 1  столбец 7 — такого числа в массиве нет
//либо просто найти число в массиве, если оно есть


int[,] Create2DMassiv(int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-99, 99);
        }
    }
    return matrix;
}

int  GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Print2DMassiv(int [,] massiv)
{
 for(int i = 0; i < massiv.GetLength(0); i++)
    {
        for(int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] array)
{
    Console.Write("Введите число, которое нужно найти: ");
    int number = Convert.ToInt32(Console.ReadLine());
 for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(number == array[i,j])
           {
             Console.WriteLine($"Число {number} находится на позиции [{i};{j}]");
            return;
           }
        }
        
    }
    Console.WriteLine($"Число {number} - в массиве нет");
}

int rows = GetInput("Введите количество строк массива: ");
int columns = GetInput("Введите количество столбцов массива: ");
int [,] massiv = Create2DMassiv(rows,columns);
Print2DMassiv(massiv);
 FindNumber(massiv);